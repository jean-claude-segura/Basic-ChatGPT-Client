using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_client
{

    /*
      "permission": [
        {
          "id": "modelperm-49FUp5v084tBB49tC4z8LPH5",
          "object": "model_permission",
          "created": 1669085501,
          "allow_create_engine": false,
          "allow_sampling": true,
          "allow_logprobs": true,
          "allow_search_indices": false,
          "allow_view": true,
          "allow_fine_tuning": false,
          "organization": "*",
          "group": null,
          "is_blocking": false
        }
      ],
     */
    public class Permission
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public long Created { get; set; }
        public bool Allow_create_engine { get; set; }
        public bool Allow_sampling { get; set; }
        public bool Allow_logprobs { get; set; }
        public bool Allow_search_indices { get; set; }
        public bool Allow_view { get; set; }
        public bool Allow_fine_tuning { get; set; }
        public string Organization { get; set; }
        public dynamic Group { get; set; }
        public bool Is_blocking { get; set; }
    }
    /*
    {
      "id": "babbage",
      "object": "model",
      "created": 1649358449,
      "owned_by": "openai",
      "permission": [
        {
          "id": "modelperm-49FUp5v084tBB49tC4z8LPH5",
          "object": "model_permission",
          "created": 1669085501,
          "allow_create_engine": false,
          "allow_sampling": true,
          "allow_logprobs": true,
          "allow_search_indices": false,
          "allow_view": true,
          "allow_fine_tuning": false,
          "organization": "*",
          "group": null,
          "is_blocking": false
        }
      ],
      "root": "babbage",
      "parent": null
    }
    */
    public class Model
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public long Created { get; set; }
        public string Owned_by { get; set; }
        public List<Permission> Permission { get; set; } = new();
        public string Root { get; set; }
        public dynamic Parent { get; set; }

    }

    /*
  "object": "list",
  "data": [
    {
      "id": "babbage",
      "object": "model",
      "created": 1649358449,
      "owned_by": "openai",
      "permission": [
        {
          "id": "modelperm-49FUp5v084tBB49tC4z8LPH5",
          "object": "model_permission",
          "created": 1669085501,
          "allow_create_engine": false,
          "allow_sampling": true,
          "allow_logprobs": true,
          "allow_search_indices": false,
          "allow_view": true,
          "allow_fine_tuning": false,
          "organization": "*",
          "group": null,
          "is_blocking": false
        }
      ],
      "root": "babbage",
      "parent": null
    },
     */
    public class Models
    {
        public string Object { set; get; }
        public List<Model> Data { get; set; }
    }
}
