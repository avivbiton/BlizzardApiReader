using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BlizzardApiReader.Diablo.Models;
using System.IO;

namespace BlizzardApiReader
{
    public class ApiReader
    {
        public static string Url { get; } = "https://eu.api.battle.net";
        public static string Key { get; set; }

        public static void ReadKeyFromFile(string path)
        {
            if (File.Exists(path))
            {

                string key = File.ReadAllText(path);
                Key = $"?locale=en_GB&apikey={key}";

            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public async Task<T> Get<T>(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                query = ValidateFormat(query);

                HttpResponseMessage responseMessage = await client.GetAsync(Url + query + Key);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }

            }

            return default(T);
        }

        private string ValidateFormat(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }
    }
}
