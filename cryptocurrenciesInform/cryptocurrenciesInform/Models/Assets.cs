using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    public class Assets
    {
        public Asset asset { get; set; }
    }
    public class Asset
    {
        public string asset_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal volume_24h { get; set; }
        public decimal change_1h { get; set; }
        public decimal change_24h { get; set; }
        public decimal change_7d { get; set; }
    }
}
