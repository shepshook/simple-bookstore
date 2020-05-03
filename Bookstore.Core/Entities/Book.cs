using System;
using System.Collections.Generic;

namespace Bookstore.Core.Entities
{
    public class Book : Entity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublicationDate { get; set; }
        public double? Rating { get; set; }
        public string CoverImage { get; set; }
        public Guid? PublisherId { get; set; }
        
        public Publisher Publisher { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}