using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable("Publisher");
        
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Status).HasDefaultValueSql("((1))");
        builder.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
        builder.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");
    }
}
