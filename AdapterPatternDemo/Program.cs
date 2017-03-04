using AdapterPatternDemo.Concretes;
using AdapterPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            IDuck fakeTurkey = new TurkeyAdapter(turkey);
            Console.WriteLine("\n----------Turkey Said-----------\n");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\n-----------Duck Said---------\n");
            TestDuck(duck);
            Console.WriteLine("\n----------FakeTurkey Said----------\n");
            TestDuck(fakeTurkey);

           

        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
