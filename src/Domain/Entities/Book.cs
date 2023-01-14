using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Isbn { get; set; }

    public int? PublisherId { get; set; }

    public decimal? Price { get; set; }

    public int Status { get; set; }

    public DateTime TimeInsert { get; set; }

    public DateTime TimeUpdate { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<Author> Authors { get; } = new List<Author>();

    public virtual ICollection<Category> Categories { get; } = new List<Category>();
}
