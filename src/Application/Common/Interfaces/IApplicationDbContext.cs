using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Domain.Entities.Book> Books { get; set; }
    DbSet<Domain.Entities.Publisher> Publishers { get; set; }
    DbSet<Domain.Entities.Author> Authors { get; set;  }
    DbSet<Domain.Entities.Category> Categories { get; set; }
    //Task<int> SaveChangesAsync(CancellationToken cancellationToken);    
}
