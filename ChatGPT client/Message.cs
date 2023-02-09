using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    public class Message
    {
        public Message(string prompt, int max_tokens,
              decimal temperature, decimal top_p, decimal frequency_penalty, decimal presence_penalty, List<string>? stop = null, string? model = null)
        {
            Prompt = prompt;
            Max_tokens = max_tokens;
            Temperature = temperature;
            Top_p = top_p;
            Frequency_penalty = frequency_penalty;
            Presence_penalty = presence_penalty;
            if (stop is not null) Stop = stop;
            if (model is not null) Model = model;
        }

        public Message(List<string> history, int max_tokens,
              decimal temperature, decimal top_p, decimal frequency_penalty, decimal presence_penalty, List<string>? stop = null, string? model = null)
        {
            Prompt = "";
            foreach (var item in history)
                Prompt += item;

            Max_tokens = max_tokens;
            Temperature = temperature;
            Top_p = top_p;
            Frequency_penalty = frequency_penalty;
            Presence_penalty = presence_penalty;
            if (stop is not null) Stop = stop;
            if (model is not null) Model = model;
        }

        public string Model { get; set; } = "text-davinci-003";
        public string Prompt;
        public int Max_tokens { get; set; }
        public decimal Temperature { get; set; }
        public decimal Top_p { get; set; }
        public decimal Frequency_penalty { get; set; }
        public decimal Presence_penalty { get; set; }
        public bool Echo { get; set; } = false;
        public List<string>? Stop { get; set; } = null;
        public int N { get; set; } = 1;
        public int Best_of { get; set; } = 1;
        //public int Logprobs { get; set; } = 1;
    }
}
