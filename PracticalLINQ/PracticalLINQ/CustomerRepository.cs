using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLINQ
{
    public class CustomerRepository
    {

        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;
            //foreach (var c in customerList)
            //{
            //    if (c.CustomerID == customerId)
            //    {
            //        foundCustomer = c;
            //        break;
            //    }
            //}

            //var query = from c in customerList
            //                    where customerId == c.CustomerID
            //                    select c;

            //foundCustomer = query.First();

            //foundCustomer = customerList.First(c => c.CustomerID == customerId);

            //foundCustomer = customerList.FirstOrDefault(c =>
            //{
            //    Console.WriteLine(c.LastName);
            //    return c.CustomerID == customerId;
            //});

            foundCustomer = customerList.Where(c => 
                                                c.CustomerID == customerId).Skip(1).FirstOrDefault();

            return foundCustomer;
        }




        public List<Customer> Retrieve()
        {

         List<Customer> customerList = new List<Customer>
            {
            new Customer(){
                FirstName = "Tatev",
                LastName = "Aghasaryan",
                CustomerID = 1,
                CustomerTypeID = 1,
                EmailAddress = "tatevik@gmail.com"
            },

            new Customer(){
                FirstName = "Arev",
                LastName = "Arevyan",
                CustomerID = 2,
                CustomerTypeID = null,
                EmailAddress = "arevik@gmail.com"
            },

            new Customer(){
                FirstName = "Tigran",
                LastName = "Petrosyan",
                CustomerID = 3,
                CustomerTypeID = 3,
                EmailAddress = "tigran@gmail.com"
            },
            new Customer(){
                FirstName = "Edgar",
                LastName = "Harutyunyan",
                CustomerID = 4,
                CustomerTypeID = null,
                EmailAddress = "edgar@gmail.com"
            }
        };
            return customerList;
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(c => c.LastName + " " + c.FirstName);
            return query;
        }

        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new { 
            Name = c.LastName + "," + c.FirstName,
            c.EmailAddress
            });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ":" + item.EmailAddress);
            }
            return query;
        }


        

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName).ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
            return customerList.OrderByDescending(c => c.CustomerTypeID.HasValue).ThenBy(c => c.CustomerTypeID);
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            //return customerList.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
            return Enumerable.Repeat(new Customer(), 5);
        }

        }

}
