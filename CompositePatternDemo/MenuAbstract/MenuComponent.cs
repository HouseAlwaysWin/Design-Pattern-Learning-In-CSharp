using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo.MenuAbstract
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName
        {
            get { throw new NotSupportedException(); }
            protected set { value = GetName; }
        }


        public virtual string GetDescription
        {
            get { throw new NotSupportedException(); }
            protected set { value = GetDescription; }
        }


        public virtual double GetPrice
        {
            get { throw new NotSupportedException(); }
            protected set { value = GetPrice; }
        }



        public virtual bool IsVegetarian
        {
            get { throw new NotSupportedException(); }
            protected set { value = IsVegetarian; }
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
