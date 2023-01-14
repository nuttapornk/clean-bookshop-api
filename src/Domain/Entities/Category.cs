namespace Domain.Entities;

public partial class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Status { get; set; }
    public DateTime TimeInsert { get; set; }
    public DateTime TimeUpdate { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
