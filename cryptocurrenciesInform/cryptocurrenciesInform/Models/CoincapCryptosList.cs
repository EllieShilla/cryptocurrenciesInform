using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    public class CoincapCryptosList
    {
        public List<CoincapCrypto> data { get; set; }
    }

    public class CoincapCrypto
    {
        public string id { get; set; }
        public decimal volumeUsd24Hr { get; set; }
        public decimal changePercent24Hr { get; set; }
    }
}
