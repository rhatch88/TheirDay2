﻿using Microsoft.AspNetCore.Mvc;

namespace TheirDay2.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
