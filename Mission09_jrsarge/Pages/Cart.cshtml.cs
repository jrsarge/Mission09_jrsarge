using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_jrsarge.Infrastructure;
using Mission09_jrsarge.Models;

namespace Mission09_jrsarge.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public CartModel (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public basket basket { get; set; }
        public void OnGet()
        {
            basket = HttpContext.Session.GetJson<basket>("basket") ?? new basket();
        }

        public IActionResult OnPost(int bookID)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookID);

            basket = HttpContext.Session.GetJson<basket>("basket") ?? new basket();
            basket.AddItem(b, 1);

            HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(basket);
        }
    }
}
