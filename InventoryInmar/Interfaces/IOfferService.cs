using InventoryInmar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryInmar.Interfaces
{
    public interface IOfferService
    {
        List<Product> GetAllProducts();
        List<Offer> GetTodayOfferProducts();
        Product GetSecondLowest();
        void Save(Product product);
    }
}
