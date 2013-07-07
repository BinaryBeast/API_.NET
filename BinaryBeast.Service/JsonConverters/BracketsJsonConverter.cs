using BinaryBeast.Service.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.JsonConverters
{
    public class BracketsJsonConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Bracket>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<Bracket> result = new List<Bracket>();
            foreach (var jsonBracket in JObject.Load(reader))
            {
                var bracket = new Bracket();
                bracket.BracketRounds = new List<BracketRound>();

                foreach (var jsonRound in jsonBracket.Value)
                {
                    var bracketRound = new BracketRound();
                    bracketRound.BracketMatches = new List<BracketMatch>();

                    foreach (var jsonMatch in jsonRound)
                    {
                        var breacketMatch = JsonConvert.DeserializeObject<BracketMatch>(jsonMatch.ToString());

                        bracketRound.BracketMatches.Add(breacketMatch);
                    }
                    bracketRound.DisplayName = "Round of: " + bracketRound.BracketMatches.Count * 2;
                        //bracketRound.BracketMatches.Sum(x => (x.Team1 != null ? 1 : 0) + (x.Team2 != null ? 1 : 0));
                    bracket.BracketRounds.Add(bracketRound);
                }

                result.Add(bracket);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanWrite is false. The type will skip the converter.");
        }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }
    }
}
