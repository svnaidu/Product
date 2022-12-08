using InventoryInmar.Entities;
using InventoryInmar.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryInmar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        [HttpGet("GetAllProducts")]
        public List<Product> GetProducts()
        {
            return _offerService.GetAllProducts();
        }
        [HttpGet("GetTodayOfferProducts")]
        public List<Offer> GetTodayOffer()
        {
            return _offerService.GetTodayOfferProducts();
        }
        [HttpGet("GetSecondLowest")]
        public Product GetSecondLowest()
        {
            return _offerService.GetSecondLowest();
        }
        [HttpPost("AddProduct")]
        public void Post(Product product)
        {
            _offerService.Save(product);
        }

    }
}
