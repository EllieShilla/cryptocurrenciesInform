using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    internal class GatherInformation
    {
        static readonly HttpClient client = new HttpClient();
        private readonly string rates_url = "https://api.coincap.io/v2/rates";

        private async Task<string> GetDataString()
        {

            HttpResponseMessage response = await client.GetAsync(rates_url);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<List<Crypto>> RetrieveCurrencyAsync()
        {
            Cryptos cryptos = Newtonsoft.Json.JsonConvert.DeserializeObject<Cryptos>(await GetDataString());
            List<Crypto> newCryptos = cryptos.data.Where(i => i.type.Equals("crypto")).OrderByDescending(i => i.rateUsd).ToList();


            foreach (var i in newCryptos)
            {
                Console.WriteLine(i.id);
            }

            return cryptos.data.Where(i => i.type.Equals("crypto")).OrderByDescending(i => i.rateUsd).ToList();
        }
    }
}
