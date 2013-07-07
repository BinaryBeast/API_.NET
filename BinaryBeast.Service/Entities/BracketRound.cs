using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.Entities
{
    public class BracketRound
    {
        public List<BracketMatch> BracketMatches { get; set; }
        public string DisplayName { get; set; }
    }
}
