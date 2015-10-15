using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "hello world!";
            Console.WriteLine(source.ConvertToTitleCase());
            Console.ReadKey();
        }
    }
}
