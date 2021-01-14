using Microsoft.AspNetCore.Mvc;

namespace Balada.Web.Mvc.Controllers
{
    public class AlienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
