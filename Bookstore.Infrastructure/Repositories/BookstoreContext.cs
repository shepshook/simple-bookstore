using Bookstore.Core.Entities;
using Bookstore.Infrastructure.Repositories.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class BookstoreContext : DbContext
    {
        private const string Connection =
            "Data Source=(local);Initial Catalog=Bookstore;Integrated Security=true";

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookAuthorConfiguration());
            builder.ApplyConfiguration(new PublisherConfiguration());
        }
    }
}