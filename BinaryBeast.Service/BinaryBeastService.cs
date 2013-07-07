using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service
{
    public class BinaryBeastService
    {
        private readonly string apiKey;
        private readonly string username;
        private readonly string password;

        private BinaryBeastTournamentService tournamentService;

        public BinaryBeastService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public BinaryBeastService(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        internal string ApiKey { get { return apiKey; } }

        public BinaryBeastTournamentService TournamentService
        {
            get
            {
                if (tournamentService == null)
                    tournamentService = new BinaryBeastTournamentService(this);

                return tournamentService;
            }
        }

    }
}
