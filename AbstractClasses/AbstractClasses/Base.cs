using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Base
    {
        public abstract void AbstractMethod();
        
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Base Virtual method");
        }
        public void JustMethod()
        {
            Console.WriteLine("Base Just method");
        }
    }
}
