﻿using Microsoft.AspNetCore.Mvc;

namespace Balada.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
