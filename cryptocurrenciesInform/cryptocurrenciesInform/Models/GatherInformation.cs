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
        private HttpResponseMessage response;
        private readonly string rates_url_coincap = "https://api.coincap.io/v2/rates";
        private readonly string assets_url_cryptingup = "https://cryptingup.com/api/assets/";
        private readonly string markets_url_coincap = "https://api.coincap.io/v2/assets/";
        private readonly string asset_url_coincap = "https://api.coincap.io/v2/assets/";
        private readonly string asset_url_coingecko = "https://api.coingecko.com/api/v3/search?query=";
        private readonly string all_asset_url_coincap = "https://api.coincap.io/v2/assets";

        private Crypto _cryptoDetail;
        public GatherInformation() { }

        public GatherInformation(Crypto cryptoDetail)
        {
            _cryptoDetail = cryptoDetail;
            assets_url_cryptingup += _cryptoDetail.symbol;
            markets_url_coincap += _cryptoDetail.id + "/markets";
            asset_url_coincap += _cryptoDetail.id;
            asset_url_coingecko += _cryptoDetail.symbol;
        }

        private async Task<string> GetDataString(string request)
        {
            switch (request)
            {
                case "list":
                    {
                        response = await client.GetAsync(rates_url_coincap);
                    }
                    break;
                case "assetsBySymbol":
                    {
                        response = await client.GetAsync(assets_url_cryptingup);
                    }
                    break;
                case "markets":
                    {
                        response = await client.GetAsync(markets_url_coincap);
                    }
                    break;
                case "assetsByName":
                    {
                        response = await client.GetAsync(asset_url_coincap);
                    }
                    break;
                case "assetsBySymbol_2":
                    {
                        response = await client.GetAsync(asset_url_coingecko);
                    }
                    break;
                case "convert":
                    {
                        response = await client.GetAsync(all_asset_url_coincap);
                    }
                    break;
            }

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<List<Crypto>> RetrieveCurrencyAsync()
        {
            Cryptos cryptos = Newtonsoft.Json.JsonConvert.DeserializeObject<Cryptos>(await GetDataString("list"));
            return cryptos.data.Where(i => i.type.Equals("crypto")).OrderByDescending(i => i.rateUsd).ToList();
        }

        public async Task<Asset> RetrieveAssetAsync()
        {
            Assets assets = Newtonsoft.Json.JsonConvert.DeserializeObject<Assets>(await GetDataString("assetsBySymbol"));
            return assets.asset;
        }

        public async Task<List<Market>> RetrieveMarketsAsync()
        {
            DataMarket dataMarket = Newtonsoft.Json.JsonConvert.DeserializeObject<DataMarket>(await GetDataString("markets"));
            return dataMarket.data.Where(i => i.baseId.Equals(_cryptoDetail.id)).ToList();
        }

        public async Task<AssetForSearch> RetrieveCurrencyByNameAsync()
        {
            DataAsset dataAsset = Newtonsoft.Json.JsonConvert.DeserializeObject<DataAsset>(await GetDataString("assetsByName"));
            return dataAsset.data;
        }

        public async Task<AssetForSearch> RetrieveCurrencyAsyncBySymbol()
        {
            DataAsset2 dataAsset = Newtonsoft.Json.JsonConvert.DeserializeObject<DataAsset2>(await GetDataString("assetsBySymbol_2"));
            return dataAsset.coins[0];
        }

        public async Task<List<ConvertCurrency>> RetrieveConvertCurrencyAsync()
        {
            ConvertData cryptos = Newtonsoft.Json.JsonConvert.DeserializeObject<ConvertData>(await GetDataString("convert"));
            return cryptos.data;
        }
    }
}
