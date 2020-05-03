using Bookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Infrastructure.Repositories.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            builder.HasKey(x => new { x.BookId, x.AuthorId });

            builder.HasOne(x => x.Book)
                .WithMany(y => y.BookAuthors)
                .HasForeignKey(x => x.BookId);
            
            builder.HasOne(x => x.Author)
                .WithMany(y => y.BookAuthors)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}