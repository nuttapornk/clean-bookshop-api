using Domain.Entities;
using IdentityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Book");

        builder.HasIndex(e => e.PublisherId, "IX_Book_PublisherId");

        builder.Property(e => e.Isbn).HasMaxLength(13);
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Price).HasColumnType("decimal(8, 2)");
        builder.Property(e => e.Status).HasDefaultValueSql("((1))");
        builder.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
        builder.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");

        builder.HasOne(d => d.Publisher).WithMany(p => p.Books).HasForeignKey(d => d.PublisherId);

        builder.HasMany(d => d.Authors).WithMany(p => p.Books)
            .UsingEntity<Dictionary<string, object>>(
                "BookAuthor",
                r => r.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                l => l.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                j =>
                {
                    j.HasKey("BookId", "AuthorId");
                    j.ToTable("BookAuthor");
                    j.HasIndex(new[] { "AuthorId" }, "IX_BookAuthor_AuthorId");
                });

        builder.HasMany(d => d.Categories).WithMany(p => p.Books)
        .UsingEntity<Dictionary<string, object>>(
            "BookCategory",
            r => r.HasOne<Category>().WithMany().HasForeignKey("CategoryId"),
            l => l.HasOne<Book>().WithMany().HasForeignKey("BookId"),
            j =>
            {
                j.HasKey("BookId", "CategoryId");
                j.ToTable("BookCategory");
                j.HasIndex(new[] { "CategoryId" }, "IX_BookCategory_CategoryId");
            }
            );
    }
}
