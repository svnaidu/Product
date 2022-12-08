using InventoryInmar.Entities;
using InventoryInmar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryInmar.Services
{
    public class OfferService : IOfferService
    {
        public OfferService()
        {
            AddProducts();
        }
        private List<Product> Inventory = new List<Product>();

        public List<Product> GetAllProducts()
        {
           
            return Inventory;
        }

        public Product GetSecondLowest()
        {
            var prooducts = Inventory.OrderBy(x => x.Price);
            return prooducts.Skip(1).Take(1).FirstOrDefault();
        }

        public List<Offer> GetTodayOfferProducts()
        {

            var offers = new List<Offer>()
            {
                new Offer("ComboPackage1",Inventory.Take(3).ToList()){},
                new Offer("ComboPackage2",Inventory.Skip(1).Take(3).ToList()){},
                new Offer("ComboPackage3",Inventory.Skip(2).Take(3).ToList()){},
                new Offer("ComboPackage4",Inventory.Skip(3).Take(3).ToList()){}
            };
            return offers;
        }

        public void Save(Product product)
        {
            Inventory.Add(product);
        }

        private void AddProducts()
        {
            if (!Inventory.Any())
            {
                Inventory.Add(
                   new Product("P1", 1000, "P1 desc") { });
                Inventory.Add(
                    new Product("P2", 200, "P2 desc") { });
                Inventory.Add(
                                new Product("P3", 400, "P3 desc") { });
                Inventory.Add(
                    new Product("P4", 700, "P4 desc") { });
                Inventory.Add(
                    new Product("P5", 600, "P5 desc") { }
                    );
                Inventory.Add(
                   new Product("P6", 800, "P6 desc") { }
                   );
            }
        }
    }
}
