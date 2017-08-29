using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_SumStringsAsNumbers
{
    class Kata
    {
        public static string sumStrings(string a, string b)
        {
            return Convert.ToString(Convert.ToDecimal(a) + Convert.ToDecimal(b));
        }
    }
}
