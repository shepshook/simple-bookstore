using System;
using Bookstore.Core.Entities;

namespace Bookstore.Core.Repositories
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}