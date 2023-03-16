using Microsoft.AspNetCore.Mvc;
using Mission09_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Controllers
{
    public class CheckoutController : Controller
    {
        public CheckoutController()
        {

        }

        [HttpGet]
        public IActionResult RingOut()
        {
            return View(new Checkout());
        }

        [HttpPost]
        public IActionResult RingOut(Checkout checkout)
        {

        }
    }
}
