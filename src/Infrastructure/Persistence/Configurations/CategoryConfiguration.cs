using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");

        builder.Property(e => e.Name).HasMaxLength(200);
        builder.Property(e => e.Status).HasDefaultValueSql("((1))");
        builder.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
        builder.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");
    }
}
