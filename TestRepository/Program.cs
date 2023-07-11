using Acc.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acc.DataLayer.Services;
using Acc.DataLayer;
using System.Reflection;
using Acc.DataLayer.Context;

namespace TestRepository
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork dB = new UnitOfWork();
           var list =  dB.CustomerRepository.GetAllCustomers();
            dB.Dispose();
        }
    }
}
