using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository cust = new CustomerRepository();
            var custList = cust.Retrieve();
            // var result = cust.Find(custList,3);
             var result = cust.SortByName(custList);
            
            Console.WriteLine(result);



            Console.ReadKey();
        }
    }
}
