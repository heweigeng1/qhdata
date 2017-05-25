using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public static class extend
    {
        public static decimal ToDec(this string str)
        {
            if (decimal.TryParse(str, out decimal num))
            {
                return num;
            }
            return default(decimal);
        }
    }
}
