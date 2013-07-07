using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class Match
    {

        [JsonProperty("TourneyTeamID")]
        public string TournamentId { get; set; }

        [JsonProperty("TourneyMatchID")]
        public int TourneyMatchId { get; set; }

        [JsonProperty("TourneyTeamID")]
        public int TourneyTeam1Id { get; set; }

        [JsonProperty("OTourneyTeamID")]
        public int TourneyTeam2Id { get; set; }

        [JsonProperty("Bracket")]
        public int Bracket { get; set; }

        [JsonProperty("Draw")]
        public int Draw { get; set; }

        [JsonProperty("ReplayPack")]
        public string ReplayPack { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("Score")]
        public string ScoreTeam1 { get; set; }

        [JsonProperty("OScore")]
        public string ScoreTeam2 { get; set; }

       
    }
}
