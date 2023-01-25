using Domain.Common;

namespace Domain.Entities;

public partial class Publisher : BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public DateTime TimeInsert { get; set; }

    public DateTime TimeUpdate { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
