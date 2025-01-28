using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerservice;

        public SellersController(SellerService sellerservice)
        {
            _sellerservice = sellerservice;
        }
        public IActionResult Index() 
        {
            var list = _sellerservice.FindAll();
            return View(list);
        }
    }
}
