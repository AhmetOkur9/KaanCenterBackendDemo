using KaanCenterBackendDemo.Abstract;
using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Concrete
{
    public class CustomerManger : CustomerControl
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManger(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer Saved");
            }
            else
            {
                throw new Exception("Not a valid customer");
            }
            base.Save(customer);
        }
        public override void Update(Customer customer) 
        {
            base.Update(customer);
        }
        public override void Delete(Customer customer)
        {
            base.Delete(customer);
        }

    }
}
