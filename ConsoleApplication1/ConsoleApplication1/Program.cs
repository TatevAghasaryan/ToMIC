using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 4, 8, 9, 10, 11 };
            int[] arr2 = (int[])arr1.Clone();
            Array.Copy(arr1, arr2, 5);
            Console.WriteLine();
            Console.ReadKey();
            ;
        }
    }
}
