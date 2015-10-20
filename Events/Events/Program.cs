using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PrintStarted += (sender, e) => { Console.WriteLine("Print is started"); };
            printer.Printing += (sender, e) => { Console.WriteLine("Printing"); };
            printer.PrintFinished += (sender, e) => { Console.WriteLine("Print is finished"); };
            printer.Print(5);
            Console.ReadKey();
        }
    }
}
