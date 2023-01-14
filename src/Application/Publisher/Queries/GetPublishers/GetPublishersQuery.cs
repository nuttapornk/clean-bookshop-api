using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Publisher.Queries.GetPublishers;

public record GetPublishersQuery : IRequest<IEnumerable<GetPublishersRes>>
{
    public string Name { get; set; } = string.Empty;
}


public class GetPublishersQueryHandler : IRequestHandler<GetPublishersQuery, IEnumerable<GetPublishersRes>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    public GetPublishersQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetPublishersRes>> Handle(GetPublishersQuery request, CancellationToken cancellationToken)
    {
        var q1 = _context.Publishers
            .AsNoTracking()
            .AsQueryable();

        if (!string.IsNullOrEmpty(request.Name))
        {
            q1 = q1.Where(a => a.Name.Contains(request.Name));
        }

        return await q1.Select(a => new GetPublishersRes
        {
            Id = a.Id,
            Name = a.Name,
        }).ToListAsync(cancellationToken);      
    }
}


    



