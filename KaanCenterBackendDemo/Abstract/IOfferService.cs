using KaanCenterBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaanCenterBackendDemo.Abstract
{
    internal interface IOfferService
    {
        void Add(Offer offer,Product product,Customer customer);
        void Delete(Offer offer,Product product,Customer customer);
    }
}
