using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jrsarge.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
