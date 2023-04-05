using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
