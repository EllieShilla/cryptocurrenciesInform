using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    public class Crypto
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public decimal rateUsd { get; set; }
        public string type { get; set; }
        public string currencyName { get; set; }
        public decimal volumeUsd24Hr { get; set; }
        public decimal changePercent24Hr { get; set; }
    }

    public class Cryptos
    {
        public List<Crypto> data { get; set; }
    }
}
