using Bookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Infrastructure.Repositories.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(1024);
            builder.Property(x => x.Description);
            builder.Property(x => x.PublicationDate).HasColumnType("date");
            builder.Property(x => x.Rating);
            builder.Property(x => x.CoverImage);

            builder.HasOne(x => x.Publisher)
                .WithMany(y => y.Books)
                .IsRequired(false)
                .HasForeignKey(x => x.PublisherId);
        }
    }
}