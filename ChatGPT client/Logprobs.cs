using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    public class Logprobs
    {
        public List<string> Tokens { get; set; } = null;
        public List<decimal> Token_logprobs { get; set; } = null;
        public List<dynamic> Top_logprobs { get; set; } = null;
        public List<int> Text_offset { get; set; } = null;
    }
}
