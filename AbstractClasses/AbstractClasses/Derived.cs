using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Derived : Base
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived Abstract method");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("Derived Virtual method");
        }
        public void JustMethod()
        {
            Console.WriteLine("Derived Just method");
        }
    }
}
