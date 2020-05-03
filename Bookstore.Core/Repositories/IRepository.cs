using System.Collections.Generic;
using Bookstore.Core.Entities;

namespace Bookstore.Core.Repositories
{
    public interface IRepository<out TEntity, in TKey> where TEntity :  Entity<TKey>
    { 
        TEntity Get(TKey key);

        IEnumerable<TEntity> All();
    }
}