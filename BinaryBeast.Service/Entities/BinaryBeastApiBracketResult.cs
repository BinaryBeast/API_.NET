using BinaryBeast.Service.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class BinaryBeastApiBracketResult<TResult> : BinaryBeastApiResult
    {
        [JsonProperty("Brackets")]
        [JsonConverter(typeof(BracketsJsonConverter))]
        public TResult Result { get; set; }

    }
}
