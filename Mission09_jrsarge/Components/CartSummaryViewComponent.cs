using Microsoft.AspNetCore.Mvc;
using Mission09_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private basket cart;
        public CartSummaryViewComponent(basket cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
