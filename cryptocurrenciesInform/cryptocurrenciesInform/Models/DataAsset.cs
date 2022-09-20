using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    public class DataAsset
    {
        public AssetForSearch data { get; set; }
    }

    public class DataAsset2
    {
        public List<AssetForSearch> coins { get; set; }
    }

    public class AssetForSearch
    {
        public string id { get; set; }
        public string symbol { get; set; }

    }
}
