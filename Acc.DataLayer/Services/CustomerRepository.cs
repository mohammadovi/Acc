using Acc.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        Acc_DBEntities dB = new Acc_DBEntities();
        public List<Customers> GetAllCustomers()
        {
            return dB.Customers.ToList();
        }
        public Customers GetCustomerById(int customerId)
        {
            return dB.Customers.Find(customerId);
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                dB.Customers.Add(customer);
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                dB.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                dB.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;

            }



        }



        public void Save()
        {
            dB.SaveChanges();
        }


    }
}
