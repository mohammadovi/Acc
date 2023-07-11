using Acc.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acc.DataLayer.Services;
using Acc.DataLayer;
using System.Reflection;

namespace TestRepository
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customer = new CustomerRepository();
            Customers addCustomer = new Customers() 
            {
                Name = "Test",  
                Email = "test",
                Mobile = "092222",
                CustomerImage ="test.pmnh"
            };
            customer.InsertCustomer(addCustomer);
            customer.Save();

            var list = customer.GetAllCustomers();

        }
    }
}
