using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void F(out string s)
        {
            //x = 4;
            s = "hello";
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string arg = "world";
            F(out arg);
            Console.WriteLine(arg);
            Console.ReadKey();
        }
    }
}
