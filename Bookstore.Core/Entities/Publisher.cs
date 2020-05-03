using System;
using System.Collections;
using System.Collections.Generic;

namespace Bookstore.Core.Entities
{
    public class Publisher : Entity<Guid>
    {
        public string Name { get; set; }
        
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}