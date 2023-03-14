using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mission09_jrsarge.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models
{
    public class SessionCart : basket
    {
        public static basket GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("basket") ?? new SessionCart();

            return cart;
        }


        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Book bookie, int qty)
        {
            base.AddItem(bookie, qty);
            Session.SetJson("basket", this);
        }

        public override void RemoveItem(Book bookie)
        {
            base.RemoveItem(bookie);
            Session.SetJson("basket", this);
        }

        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("basket");
        }

    }
}
