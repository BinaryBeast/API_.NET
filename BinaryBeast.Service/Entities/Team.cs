using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class Team
    {
        [JsonProperty("TourneyTeamID")]
        public int Id { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("InvoiceID")]
        public int InvoiceId { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("PlayerCount")]
        public int PlayerCount { get; set; }

        [JsonProperty("NetworkDisplayName")]
        public string NetworkDisplayName { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("CountryCodeShort")]
        public string CountryCodeShort { get; set; }

        [JsonProperty("RaceID")]
        public int RaceId { get; set; }

        [JsonProperty("Race")]
        public string Race { get; set; }

        [JsonProperty("Position")]
        public string Position { get; set; }

        [JsonProperty("Wins")]
        public int Wins { get; set; }

        [JsonProperty("LBWins")]
        public int LbWins { get; set; }

        [JsonProperty("Draws")]
        public int Draws { get; set; }

        [JsonProperty("BronzeWins")]
        public string BronzeWins { get; set; }

        [JsonProperty("SpoilerWins")]
        public string SpoilerWins { get; set; }

        [JsonProperty("SpoilerLBWins")]
        public string SpoilerLbWins { get; set; }

        [JsonProperty("CountryFlag")]
        public string CountryFlag { get; set; }

        [JsonProperty("RaceIcon")]
        public string RaceIcon { get; set; }
        
    }
}
