using ProxyPatternDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IActualPrices proxy = new ActualPriceProxy();

            Console.WriteLine("Gold Price:");
            Console.WriteLine(proxy.GoldPrice);

            Console.WriteLine("Silver Price:");
            Console.WriteLine(proxy.SilverPrice);
        }
    }
}
