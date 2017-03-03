using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new object();
        private Singleton()
        {

        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}
