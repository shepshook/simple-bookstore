using System;
using System.Collections.Generic;
using System.Linq;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public Author Get(Guid key) => All().First(a => a.Id == key);

        public IEnumerable<Author> All()
        {
            var context = new BookstoreContext();
            return context.Authors.Include(author => author.BookAuthors)
                .ThenInclude(bookAuthor => bookAuthor.Book);
        }
    }
}