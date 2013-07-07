using BinaryBeast.Service.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.DataAccess
{
    internal class ApiPostDataFactory
    {
        //Default values
        private const int DEFAULT_LOAD = 30;
        private const int DEFAULT_PAGE = 0;
        private const int DEFAULT_PAGE_LOAD_COUNT = 1;
        private const SortDirection DEFUALT_SORT_DIRECTION = SortDirection.Descending;

        private static List<KeyValuePair<string, string>> GetTemplate(string apiKey, string apiService)
        {
            List<KeyValuePair<string, string>> template = new List<KeyValuePair<string, string>>();

            template.Add(new KeyValuePair<string, string>("APIReturn", "json"));
            template.Add(new KeyValuePair<string, string>("APIUsePascalCase", "1"));
            template.Add(new KeyValuePair<string, string>("APIAgent", "BinaryBeast API .NET: Version 1.0.0"));

            template.Add(new KeyValuePair<string, string>("APIKey", apiKey));
            template.Add(new KeyValuePair<string, string>("APIService", apiService));

            return template;
        }

        internal static List<KeyValuePair<string, string>> CreateListPostData(string apiKey, string apiService, int limit)
        {
            //Create basics
            List<KeyValuePair<string, string>> postData = GetTemplate(apiKey, apiService);

            if (limit != DEFAULT_LOAD)
            {
                postData.Add(new KeyValuePair<string, string>("limit", limit.ToString()));
            }

            return postData;
        }

        internal static List<KeyValuePair<string, string>> CreateSearchPostData(string apiKey, string apiService, string filter, int page, int pageLoadCount, int pageSize, SortDirection sortDirection)
        {
            //Create basics
            List<KeyValuePair<string, string>> postData = GetTemplate(apiKey, apiService);

            postData.Add(new KeyValuePair<string, string>("Filter", filter));
            //postData.Add(new KeyValuePair<string, string>("order", string.Empty)); //TODO

            if (page != DEFAULT_PAGE)
            {
                postData.Add(new KeyValuePair<string, string>("Page", page.ToString()));
            }

            if (pageLoadCount != DEFAULT_PAGE_LOAD_COUNT)
            {
                postData.Add(new KeyValuePair<string, string>("PageLoadCount", pageLoadCount.ToString()));
            }

            if (pageSize != DEFAULT_LOAD)
            {
                postData.Add(new KeyValuePair<string, string>("PageSize", pageSize.ToString()));
            }

            if (sortDirection != DEFUALT_SORT_DIRECTION)
            {
                switch (sortDirection)
                {
                    case SortDirection.Ascending:
                        postData.Add(new KeyValuePair<string, string>("Direction", "asc"));
                        break;
                    case SortDirection.Descending:
                        postData.Add(new KeyValuePair<string, string>("Direction", "desc"));
                        break;
                    default:
                        break;
                }
            }

            return postData;
        }

        internal static List<KeyValuePair<string, string>> CreateIdPostData(string apiKey, string apiService, string tournamentId)
        {
            //Create basics
            List<KeyValuePair<string, string>> postData = GetTemplate(apiKey, apiService);

            postData.Add(new KeyValuePair<string, string>("tourney_id", tournamentId));

            return postData;
        }
    }
}
