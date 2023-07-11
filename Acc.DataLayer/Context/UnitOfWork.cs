using Acc.DataLayer.Repository;
using Acc.DataLayer.Services;
using Acc.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        Acc_DBEntities dB = new Acc_DBEntities();

        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(dB);
                }
                return _customerRepository;
            }
            
        }

        public void Dispose()
        {
            dB.Dispose();
        }
    }
}
