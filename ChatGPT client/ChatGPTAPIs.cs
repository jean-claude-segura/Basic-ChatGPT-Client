﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Speech.Synthesis;
using System.Dynamic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

namespace ChatGPT_client
{
    public class ChatGPTInstance
    {
        static private Models? _Models = null;
        static public Models Models { get { return _Models; } }
        static private List<string> _completions = new List<string>();
        static public List<string> Completions { get => _completions; }
        static private string? _openAIApiKey { get; set; } = null;
        public int Tokens { get; set; }
        public Model? Model { get; private set; } = null;
        public int Max_tokens { get; set; }
        public decimal Temperature { get; set; }
        public decimal Top_p { get; set; }
        public decimal Frequency_penalty { get; set; }
        public decimal Presence_penalty { get; set; }
        public bool Echo { get; set; } = false;
        public List<string>? Stop { get; set; } = null;
        public int N { get; set; } = 1;
        public int Best_of { get; set; } = 1;
        public bool Stream { get; set; } = false;

        private List<Tuple<string, string>> _conversation { get; set; } = new List<Tuple<string, string>>();
        public List<Tuple<string, string>> Conversation { get => _conversation; }

        static public void setApiKey(string openAIApiKey)
        {
            _openAIApiKey = openAIApiKey;
        }

        static public bool isApiKeyOk() => !string.IsNullOrWhiteSpace(_openAIApiKey);

        public bool SetModel(string model)
        {
            Model = string.IsNullOrWhiteSpace(model) ? null : Models?.Data.FirstOrDefault(_ => _.Id == model);
            return Model is not null;
        }

        static private T? HTTPChatGPTApiGet<T>(string apiCall)
        {
            if (isApiKeyOk())
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var request = new HttpRequestMessage(new HttpMethod("GET"), apiCall))
                        {
                            request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + _openAIApiKey);

                            var response = httpClient.SendAsync(request).Result;

                            var json = response.Content.ReadAsStringAsync().Result;

                            // Pour historique :
                            _completions.Add(JsonConvert.SerializeObject(JsonConvert.DeserializeObject<dynamic>(json), Formatting.Indented));

                            return JsonConvert.DeserializeObject<T?>(json);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return default(T?);
            }
        }

        static private T? HTTPChatGPTApiPost<T>(string apiCall, Message message)
        {
            if (isApiKeyOk())
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), apiCall))
                        {
                            request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + _openAIApiKey);
                            var jsonRequest = JsonConvert.SerializeObject(
                                message,
                                Formatting.Indented,
                                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }
                                );


                            // Pour historique ;
                            _completions.Add(JsonConvert.SerializeObject(JsonConvert.DeserializeObject(jsonRequest), Formatting.Indented));

                            request.Content = new StringContent(jsonRequest);
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                            var response = httpClient.SendAsync(request).Result;
                            var json = response.Content.ReadAsStringAsync().Result;

                            // Pour historique :
                            _completions.Add(JsonConvert.SerializeObject(JsonConvert.DeserializeObject<dynamic>(json), Formatting.Indented));

                            return JsonConvert.DeserializeObject<T?>(json);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return default(T?);
            }
        }

        static public void GetModels()
        {
            var apiCall = "https://api.openai.com/v1/models";
            try
            {
                _Models = HTTPChatGPTApiGet<Models>(apiCall);
            }
            catch (Exception ex)
            {
                _completions.Add(ex.Message);
            }
        }

        private Completion? GetCompletion(Message message, int tentatives = 3)
        {
            var apiCall = "https://api.openai.com/v1/completions";
            try
            {
                Completion? completion = HTTPChatGPTApiPost<Completion>(apiCall, message);
                if (completion is not null && completion.Error is not null)
                {
                    switch (completion.Error.Type)
                    {
                        case "invalid_request_error":
                            if (completion.Error.Message.StartsWith("This model's maximum context length is "))
                            {
                                // "This model's maximum context length is 4097 tokens, however you requested 4107 tokens (107 in your prompt; 4000 for the completion). Please reduce your prompt; or completion length."
                                var temp = completion.Error.Message.Substring(completion.Error.Message.IndexOf(" tokens, however you requested ") + " tokens, however you requested ".Length);
                                temp = temp.Substring(0, temp.IndexOf(' '));
                                message.Max_tokens = Tokens - (int.Parse(temp) - Tokens);
                                return GetCompletion(message);
                            }
                            else
                            {
                                return null; // new Completion() { Choices = new List<Choice>() { new Choice() { Text = "/!\\ Erreur de requête non gérée. /!\\" } } };
                            }
                        case "server_error":
                            if (completion.Error.Message.StartsWith("That model is currently overloaded with other requests.") && tentatives > 0)
                            {
                                // "That model is currently overloaded with other requests. You can retry your request, or contact us through our help center at help.openai.com if the error persists. (Please include the request ID 6c1121ea7ff2592731192cd0fd5d85ec in your message.)"
                                Thread.Sleep(15);
                                return GetCompletion(message, --tentatives);
                            }
                            else if (completion.Error.Message.StartsWith("The server experienced an error while processing your request.") && tentatives > 0)
                            {
                                // "The server experienced an error while processing your request. Sorry about that! You can retry your request, or contact us through our help center at help.openai.com if the error persists."
                                Thread.Sleep(15);
                                return GetCompletion(message, --tentatives);
                            }
                            return null; // new Completion() { Choices = new List<Choice>() { new Choice() { Text = "/!\\ Erreur serveur non gérée. /!\\" } } }; ;
                        default: return null; // new Completion() { Choices = new List<Choice>() { new Choice() { Text = "/!\\ Erreur inconnue. /!\\" } } }; ;
                    }
                }
                else
                {
                    if (completion is not null)
                        Max_tokens = Tokens - completion.Usage.Total_tokens;
                    return completion;
                }
            }
            catch (Exception ex)
            {
                _completions.Add(ex.Message);
                return null;
            }
        }

        public Completion? GetCompletionHistorized(string prompt)
        {
            _conversation.Add(new Tuple<string, string>("HUMAN:", prompt));

            var message = new Message(_conversation.Select(_ => _.Item1 + _.Item2).ToList().Concat(new List<string>() { "AI:" }).ToList(), Max_tokens, Temperature, Top_p, Frequency_penalty, Presence_penalty, new() { "HUMAN:" }, Model.Id);

            var res = GetCompletion(message);

            if(res is not null) _conversation.Add(new Tuple<string, string>("AI:", res.Choices.First().Text + Environment.NewLine));
            
            return res;
        }

        /// <summary>
        /// Réponds-moi uniquement avec des répliques tirées de la série "Kaamelott".
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public Completion? GetCompletionSingle(string prompt)
        {
            var message = new Message(prompt, Max_tokens, Temperature, Top_p, Frequency_penalty, Presence_penalty, null, Model.Id);

            return GetCompletion(message);
        }

        public void Clear()
        {
            _completions.Clear();
            _conversation.Clear();
            Max_tokens = Tokens;
        }
    }
}
