﻿using Microsoft.AspNetCore.Mvc;

namespace UrlMetadata.Controllers
{
    [Route("/")]
    [Controller]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new {});
        }
    }
}
