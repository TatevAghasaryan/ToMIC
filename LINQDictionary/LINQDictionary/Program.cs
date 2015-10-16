using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { { 2, 3 }, { 4, 5 }, { 6, 7 }, { 8, 9 } };
           // var query = dic.Where(c => c.Key%2==0);
           //or  Dictionary<int,int> query = dic.Where(c => c.Key%2 == 0).ToDictionary(c => c.Key, c => c.Value);
            var query = dic.OrderBy(c => c.Key > 5).ThenBy(c => c.Value>7);

            
            Console.ReadKey();
        }
    }
}
