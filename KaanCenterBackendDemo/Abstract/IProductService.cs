using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Abstract
{
    internal interface IProductService
    {
        void Sell(Product product,Customer customer);
    }
}
