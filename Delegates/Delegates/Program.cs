using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int MyDelegate(int a,int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(Add);
            MyDelegate del2 = new MyDelegate(Sub);

            Console.WriteLine(del1(5, 5));
            Console.WriteLine(del2(5, 5));
            DisplayDelegateInfo(del1);
            DisplayDelegateInfo(del2);
            Console.ReadKey();

        }

        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a * b;
        }
        public static void DisplayDelegateInfo(Delegate del)
        {
            foreach (var item in del.GetInvocationList())
            {
                Console.WriteLine("Method Name {0}", del.Method);
                Console.WriteLine("Type Name {0}", del.Target);
            }
        }
    }
}
