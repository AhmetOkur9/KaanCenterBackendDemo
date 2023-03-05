using KaanCenterBackendDemo.Abstract;
using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Concrete
{
    internal class OfferService : IOfferService
    {
        public void Add(Offer offer, Product product, Customer customer)
        {
            if (customer.DateOfRegistration.Month<3 && customer.DateOfRegistration.Month > 1 )
            {
                product.Price = product.Price / 2;
                Console.WriteLine("User with "+  customer.Id + " ID purchased the "+  product.Id + " at the campaign price.Price of the product: "+product.Price + "$");
                product.Price = product.Price *2;
            }
            else
            {
                Console.WriteLine(product.Id + " has been sold.ID of the user who bought the game: " + customer.Id);
            }
        }

        public void Delete(Offer offer, Product product, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
