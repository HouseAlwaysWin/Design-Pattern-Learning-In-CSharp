using CompoundPatternDemo.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            DuckSumulator ds = new DuckSumulator(new DuckFactory());
            ds.Simulate();
        }
    }
}
