using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class BinaryBeastApiListResult<TResult> : BinaryBeastApiResult
    {
        [JsonProperty("list")]
        public TResult Result { get; set; }
    }
}
