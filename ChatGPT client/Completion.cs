using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{
    /*
    {
      "error": {
        "message": "This model's maximum context length is 4097 tokens, however you requested 4107 tokens (107 in your prompt; 4000 for the completion). Please reduce your prompt; or completion length.",
        "type": "invalid_request_error",
        "param": null,
        "code": null
        }
    }
    */
    public class Error
    {
        public string Message { get; set; }
        public string Type { get; set; }
        public dynamic Param { get; set; }
        public dynamic Code { get; set; }
    }

    /*
    """id"": ""cmpl-6fvdptgOwf3ggXBgs0CL2uhTCLihB"""
    """object"": ""text_completion"""
    """created"": 1675451041";""
    """model"": ""text-davinci-002"""
    """choices"": [
      {
        ""text"": ""\n\nYou can use our map to find a friendly venue in your area.\n\nNeed help finding the right venue?\n\nDrop us a line and we'll help you find the perfect venue for your event."",
        ""index"": 0,
        ""logprobs"": null,
        ""finish_reason"": ""stop""
      }
    ]"
     */
    public class Completion
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public string Created { get; set; }
        public string Model { get; set; }
        public List<Choice> Choices = new();
        public Usage Usage { get; set; }
        public Error Error { get; set; }
    }
}
