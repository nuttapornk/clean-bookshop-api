using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Persistence;

public partial class BookShop1Context : DbContext
{
    public BookShop1Context()
    {
    }

    public BookShop1Context(DbContextOptions<BookShop1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.ToTable("Author");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.FullName)
                .HasMaxLength(201)
                .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PenName).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.HasIndex(e => e.PublisherId, "IX_Book_PublisherId");

            entity.Property(e => e.Isbn).HasMaxLength(13);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books).HasForeignKey(d => d.PublisherId);

            entity.HasMany(d => d.Authors).WithMany(p => p.Books)
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
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.ToTable("Publisher");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.TimeInsert).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TimeUpdate).HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
