using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models
{
    public class basket
    {
        //first part declares second part instantiates
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem(Book bookie, int qty)
        {
            BasketLineItem line = Items
                .Where(c => c.Book.BookId == bookie.BookId)
                .FirstOrDefault();

            if(line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = bookie,
                    Quantity = qty
                });
            }

            else
            {
                line.Quantity = line.Quantity + qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
