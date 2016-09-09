using Microsoft.AspNetCore.Mvc;
 
namespace DAIVAN
 {
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}