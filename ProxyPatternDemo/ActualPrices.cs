using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternDemo
{
    public class ActualPrices : IActualPrices
    {
        public string DollarPrice
        {
            get
            {
                return "100";
            }
        }

        public string GoldPrice
        {
            get
            {
                return "50";
            }
        }

        public string SilverPrice
        {
            get
            {
                return "20";
            }
        }
    }
}
