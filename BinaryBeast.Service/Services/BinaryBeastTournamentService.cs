using BinaryBeast.Service.DataAccess;
using BinaryBeast.Service.Entities;
using BinaryBeast.Service.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service
{
    public class BinaryBeastTournamentService
    {
        private const string LIST_POPULAR = "Tourney.TourneyList.Popular";
        private const string LIST_FEATURED = "Tourney.TourneyList.Featured";
        private const string LIST_ALL = "Tourney.TourneyList.All";
        private const string DRAW_BRACKETS = "Tourney.TourneyDraw.Brackets";

        private readonly BinaryBeastService service;

        public BinaryBeastTournamentService(BinaryBeastService service)
        {
            this.service = service;
        }

        private async Task<List<Tournament>> GetListAsync(string type, int limit)
        {
            var postData = ApiPostDataFactory.CreateListPostData(service.ApiKey, type, limit);

            var respons = await ApiRequest.GetResult<BinaryBeastApiListResult<List<Tournament>>>(postData);

            return respons.Result;
        }

        /// <summary>
        /// Get list of popular tournaments
        /// </summary>
        /// <param name="limit">Max limit to return. MinValue = 1, MaxValue = 100, Default = 30</param>
        /// <returns>List of tournaments</returns>
        public async Task<List<Tournament>> GetPopularListAsync(int limit = 30)
        {
            return await GetListAsync(LIST_POPULAR, limit);
        }

        /// <summary>
        /// Get list of featured tournaments
        /// </summary>
        /// <param name="limit">Max limit to return. MinValue = 1, MaxValue = 100, Default = 30</param>
        /// <returns>List of tournaments</returns>
        public async Task<List<Tournament>> GetFeaturedListAsync(int limit = 30)
        {
            return await GetListAsync(LIST_FEATURED, limit);
        }

        /// <summary>
        /// Get list of filtered tournaments
        /// </summary>
        /// <param name="filter">Search string</param>
        /// <param name="page">starting page number</param>
        /// <param name="pageLoadCount">number of pages to load</param>
        /// <param name="pageSize">size of page MinValue = 1, MaxValue = 100, Default = 30</param>
        /// <param name="order">Wether the list should be sorted Ascending or Descending</param>
        /// <returns>List of tournaments</returns>
        public async Task<List<Tournament>> SearchAsync(string filter, int page = 0, int pageLoadCount = 0, int pageSize = 30, SortDirection order = SortDirection.Descending)
        {
            var postData = ApiPostDataFactory.CreateSearchPostData(service.ApiKey, LIST_ALL, filter, page, pageLoadCount, pageSize, order);

            var respons = await ApiRequest.GetResult<BinaryBeastApiListResult<List<Tournament>>>(postData);

            return respons.Result;
        }

        public async Task<List<Bracket>> GetBracketsAsync(string tournamentId)
        {
            var postData = ApiPostDataFactory.CreateIdPostData(service.ApiKey, DRAW_BRACKETS, tournamentId);

            var respons = await ApiRequest.GetResult<BinaryBeastApiBracketResult<List<Bracket>>>(postData);

            return respons.Result;
        }



    }
}
