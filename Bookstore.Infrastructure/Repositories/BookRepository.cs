using System;
using System.Collections.Generic;
using System.Linq;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book Get(Guid key) => All().First(b => b.Id == key);

        public IEnumerable<Book> All()
        {
            var context = new BookstoreContext();
            return context.Books.Include(book => book.Publisher)
                .Include(book => book.BookAuthors)
                .ThenInclude(bookAuthor => bookAuthor.Author);
        }
    }
}