using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models
{
    public class EFCheckoutRepository : ICheckoutRepository
    {
        private BookstoreContext context;

        public EFCheckoutRepository(BookstoreContext temp)
        {
            context = temp;
        }


        public IQueryable<Checkout> Checkout => context.Checkout.Include(x => x.Items);

        public void SaveCheckout(Checkout checkout)
        {
            throw new NotImplementedException();
        }
    }
}
