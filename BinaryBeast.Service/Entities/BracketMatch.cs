using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryBeast.Service.Entities
{
    public class BracketMatch
    {
        [JsonProperty("Team")]
        public Team Team1 { get; set; }
        [JsonProperty("Opponent")]
        public Team Team2 { get; set; }
        [JsonProperty("Match")]
        public Match Match { get; set; }
        [JsonProperty("BracketWinner")]
        public bool BracketWinner { get; set; }

    }
}
