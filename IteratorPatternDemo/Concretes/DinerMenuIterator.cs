using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternDemo.Concretes
{
    public class DinerMenuIterator : IEnumerator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public object Current
        {
            get
            {
                MenuItem menuItem = items[position];
                position++;
                return menuItem;
            }
        }

        public bool MoveNext()
        {
            // items[posision]==null make sure Array isn't null
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
