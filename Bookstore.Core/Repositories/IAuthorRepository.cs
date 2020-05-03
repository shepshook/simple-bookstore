using System;
using Bookstore.Core.Entities;

namespace Bookstore.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author, Guid>
    {
    }
}