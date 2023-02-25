using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models
{
    //And interface is a template for a class
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
