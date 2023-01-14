using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Author");

        builder.Property(e => e.FirstName).HasMaxLength(100);
        builder.Property(e => e.FullName)
            .HasMaxLength(201)
            .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false);
        builder.Property(e => e.LastName).HasMaxLength(100);
        builder.Property(e => e.PenName).HasMaxLength(100);
        builder.Property(e => e.Status).HasDefaultValueSql("((1))");
        builder.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
        builder.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");
    }
}
