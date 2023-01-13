using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Author
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? PenName { get; set; }

    public int Status { get; set; }

    public DateTime TimeInsert { get; set; }

    public DateTime TimeUpdate { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
