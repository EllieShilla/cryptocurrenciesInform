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
            string[] strArr = str.Split("-");
            StringBuilder sb = new StringBuilder();

            foreach (string strItem in strArr)
            {
                StringBuilder buff = new StringBuilder(strItem);
                buff[0] = char.ToUpper(buff[0]);
                sb.Append(buff + " ");
            }

            str = sb.ToString();
            return str;
        }
    }
}
