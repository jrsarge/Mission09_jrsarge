using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Figure out how many pages we need
        //Cast totalNumBooks to a double and cast all those calculations to an int
        public int TotalPages => (int) Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
