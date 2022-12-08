using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryInmar.Entities
{
    public class Offer
    {
        public Offer(string offerName, List<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }
    }
}
