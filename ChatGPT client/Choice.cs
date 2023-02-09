using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    /*
        """choices"": [
          {
            ""text"": ""\n\nYou can use our map to find a friendly venue in your area.\n\nNeed help finding the right venue?\n\nDrop us a line and we'll help you find the perfect venue for your event."",
            ""index"": 0,
            ""logprobs"": null,
            ""finish_reason"": ""stop""
          }
        ]"
     */
    public class Choice
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public string Finish_reason { get; set; }
        public Logprobs Logprobs { get; set; } = null;

    }
}
