using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Models
{
    public class ConvertData
    {
        public List<ConvertCurrency> data { get; set; }
    }

    public class ConvertCurrency
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public decimal priceUsd { get; set; }
    }
}
