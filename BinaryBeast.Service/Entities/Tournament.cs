using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class Tournament
    {
        [JsonProperty("tourney_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        [JsonProperty("elimination")]
        public int Elimination { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("date_start")]
        public DateTime StartDate { get; set; }

        [JsonProperty("view_count")]
        public int ViewCount { get; set; }

        [JsonProperty("max_teams")]
        public int MaxTeams { get; set; }

        [JsonProperty("public")]
        public int Public { get; set; }

        [JsonProperty("team_mode")]
        public int TeamMode { get; set; }

        [JsonProperty("group_count")]
        public int GroupCount { get; set; }

        [JsonProperty("teams_from_group")]
        public int TeamsFromGroup { get; set; }

        [JsonProperty("buy_in")]
        public string BuyIn { get; set; }

        [JsonProperty("buy_in_currency")]
        public string BuyInCurrency { get; set; }

        [JsonProperty("layout_id")]
        public int LayoutId { get; set; }

        [JsonProperty("game_code")]
        public string GameCode { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("game_style")]
        public string GameStyle { get; set; }

        [JsonProperty("game_icon")]
        public string GameIcon { get; set; }

        [JsonProperty("network_id")]
        public string NetworkId { get; set; }

        [JsonProperty("game_header")]
        public string GameHeader { get; set; }

        [JsonProperty("game_header_background")]
        public string GameHeaderBackground { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
