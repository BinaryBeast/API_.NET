using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public abstract class BinaryBeastApiResult
    {
        [JsonProperty("result")]
        public int ResultCode { get; set; }

        [JsonProperty("api_service_time")]
        public string ServiceTime { get; set; }

        [JsonProperty("api_framework_time")]
        public string FrameworkTime { get; set; }

        [JsonProperty("api_total_time")]
        public string TotalTime { get; set; }

        [JsonProperty("api_request_id")]
        public int RequestId { get; set; }

    }
}
