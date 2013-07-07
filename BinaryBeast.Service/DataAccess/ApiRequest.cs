using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BinaryBeast.Service.DataAccess
{
    public class ApiRequest
    {
        private const string ENDPOINT_ADDRESS = "https://api.binarybeast.com/";

        public static async Task<T> GetResult<T>(List<KeyValuePair<string, string>> postData)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(ENDPOINT_ADDRESS, new FormUrlEncodedContent(postData));
                var jsonResult = await response.Content.ReadAsStringAsync();

                var result = await JsonConvert.DeserializeObjectAsync<T>(jsonResult);

                return result;
            }

        }
   }
}
