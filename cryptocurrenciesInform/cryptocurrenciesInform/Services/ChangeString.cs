using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.Services
{
    public class ChangeString
    {
        public static string UpperFirstChar(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[0] = char.ToUpper(str[0]);
            str = sb.ToString();

            return str;
        }
    }
}
