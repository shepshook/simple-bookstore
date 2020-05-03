using System;
using System.Collections.Generic;
using System.Linq;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        public Publisher Get(Guid key) => All().First(p => p.Id == key);

        public IEnumerable<Publisher> All()
        {
            var context = new BookstoreContext();
            return context.Publishers.Include(x => x.Books);
        }
    }
}