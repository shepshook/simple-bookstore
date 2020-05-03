using System;
using System.Collections.Generic;

namespace Bookstore.Core.Entities
{
    public class Author : Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<BookAuthor> BookAuthors { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}