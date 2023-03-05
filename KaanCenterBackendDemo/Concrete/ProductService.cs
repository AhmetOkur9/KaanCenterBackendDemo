using KaanCenterBackendDemo.Abstract;
using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Concrete
{
    internal class ProductService : IProductService
    {
        public void Sell(Product product,Customer customer)
        {
            Console.WriteLine(product.Name + " has been sold.ID of the user who bought the game: " + customer.Id);
        }
    }
}
