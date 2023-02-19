using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    public class Message : ChatGPTParameters
    {
        public Message(string model, string prompt, uint max_tokens,
              decimal temperature, decimal top_p, decimal frequency_penalty, decimal presence_penalty, List<string>? stop = null, string? suffix = null, bool stream = false, bool echo = false)
        {
            Prompt = prompt;
            Max_tokens = max_tokens;
            Temperature = temperature;
            Top_p = top_p;
            Frequency_penalty = frequency_penalty;
            Presence_penalty = presence_penalty;
            Stop = stop;
            Model = model;
            Suffix = suffix;
            Stream = stream;
            Echo = echo;
        }

        public Message(string model, List<string> history, uint max_tokens,
              decimal temperature, decimal top_p, decimal frequency_penalty, decimal presence_penalty, List<string>? stop = null, string? suffix = null, bool stream = false, bool echo = false)
        {
            Prompt = "";
            foreach (var item in history)
                Prompt += item;

            Max_tokens = max_tokens;
            Temperature = temperature;
            Top_p = top_p;
            Frequency_penalty = frequency_penalty;
            Presence_penalty = presence_penalty;
            Stop = stop;
            Model = model;
            Suffix= suffix;
            Stream = stream;
            Echo= echo;
        }

        public string Model { get; set; } = "text-davinci-003";
        public string Prompt;
    }
}
