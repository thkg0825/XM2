﻿using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
