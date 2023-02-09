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
        public int Prompt_tokens { get; set; }
        public int Completion_tokens { get; set; }
        public int Total_tokens { get; set; }
    }
}
