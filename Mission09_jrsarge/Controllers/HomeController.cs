﻿using Microsoft.AspNetCore.Mvc;
using Mission09_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Controllers
{
    public class HomeController : Controller
    {

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var blah = repo.Books.ToList();
            return View(blah);
        }
    }
}
