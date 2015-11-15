using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeInterview
{
    class Program
    {
        public delegate void MyDel(int x);
        
        public static void MyFunc(int x)
        {
            Console.WriteLine("MyFunc   " + x);
        }
        static ulong Fib(uint n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Fib(2)); 
            byte a = byte.MaxValue;
            byte b = byte.MaxValue - 1;
            Console.WriteLine("before a " + a);
            Console.WriteLine("before b " + b);
            a = a ^ b;
            Console.WriteLine(a.GetType());

            Console.WriteLine("sum a " + a);
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("after a " + a);
            Console.WriteLine("after b " + b);

            //try
            //{
            //    int i;
            //    long l = long.MaxValue;
            //    object o = l;
            //    i = (int)o;
            //    Console.WriteLine(l);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            
            //MyDel d1 = new MyDel(MyFunc);
            //d1(1);
            //MyDel d2 = MyFunc;
            //d2(2);
            //MyDel d3 = delegate(int x) { Console.WriteLine("MyFunc   " + x); };
            //d3(3);
            //MyDel d4 = (x) => { Console.WriteLine("MyFunc   " + x); };
            //d4(4);
            //System.Type type = typeof(int);
            //Console.WriteLine(type);
            //int i = 0;
            //Console.WriteLine(i.GetHashCode());

            //var printer = new Printer();
            //printer.PrintStarted += (s, d) => { Console.WriteLine("print started"); };

            //printer.Print();

            //Type t = typeof(Printer);
            //Console.WriteLine(t);
            //Console.WriteLine(printer.GetType());
            Console.ReadKey();
        }
    }
}
