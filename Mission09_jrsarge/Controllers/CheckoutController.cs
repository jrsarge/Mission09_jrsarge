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
        private ICheckoutRepository repo { get; set; }
        private basket basket { get; set; }

        public CheckoutController(ICheckoutRepository temp, basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult RingOut()
        {
            return View(new Checkout());
        }

        [HttpPost]
        public IActionResult RingOut(Checkout checkout)
        {
            if(basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your cart is empty!");
            }

            if(ModelState.IsValid)
            {
                checkout.Lines = basket.Items.ToArray();
                repo.SaveCheckout(checkout);
                basket.ClearCart();

                return RedirectToPage("/CheckoutCompleted");
            }
            else
            {
                return View();
            }
        }
    }
}
