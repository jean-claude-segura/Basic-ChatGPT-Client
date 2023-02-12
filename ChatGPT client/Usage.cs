using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    /*
        """usage"": {
          ""prompt_tokens"": 2,
          ""completion_tokens"": 44,
          ""total_tokens"": 46
        }
     */
    public class Usage
    {
        public uint Prompt_tokens { get; set; }
        public uint Completion_tokens { get; set; }
        public uint Total_tokens { get; set; }
    }
}
