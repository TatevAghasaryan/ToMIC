using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.AbstractMethod();
            d.VirtualMethod();
            d.JustMethod();
            Console.WriteLine("-----------");

            Base b = d;
            b.AbstractMethod();
            b.VirtualMethod();
            b.JustMethod();

            Console.ReadKey();
        }
    }
}
