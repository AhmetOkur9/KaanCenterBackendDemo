using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Abstract
{
    public abstract class CustomerControl : ICustomerService
    {
        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }

        public virtual void Save(Customer customer)
        {
            
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
