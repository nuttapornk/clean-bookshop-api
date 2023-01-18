using Application.Common.Interfaces;
using AutoMapper;
using Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReflectionIT.Mvc.Paging;

namespace Application.Publisher.Queries.GetPublishers;

public record GetPublishersQuery : IRequest<GetPublishersRes>
{
    public int Page { get; set; } = 1;
    public string Name { get; set; } = string.Empty;
    public string SortExpresstion { get; set; } = "Id";
}

public class GetPublishersQueryHandler : IRequestHandler<GetPublishersQuery, GetPublishersRes>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly AppSetting _appSetting;
    private readonly IMemoryCache _cache;

    public GetPublishersQueryHandler(IApplicationDbContext context, 
        IMapper mapper, 
        IOptions<AppSetting> appSetting,
        IMemoryCache cache )
    {
        _context = context;
        _mapper = mapper;
        _appSetting = appSetting.Value;
        _cache = cache;

    }

    public async Task<GetPublishersRes> Handle(GetPublishersQuery request, CancellationToken cancellationToken)
    {

        var temp = await _cache.GetObjectAsync<GetPublishersRes>("temp");
        if (temp != null) return temp;

        var q1 = _context.Publishers
            .Select(a=> new GetPublishersResData
            {
                Id = a.Id,
                Name = a.Name,
            })
            .AsNoTracking()
            .AsQueryable();

        if (!string.IsNullOrEmpty(request.Name))
        {
            q1 = q1.Where(a => a.Name.Contains(request.Name));
        }

        var data = await PagingList.CreateAsync(q1, _appSetting.PageSize, request.Page, request.SortExpresstion, "Id");

        

        var res = new GetPublishersRes
        {
            PageCount = data.PageCount,
            PageIndex = data.PageIndex,
            Data = data,
        };

        await _cache.SetObjectAsync("temp", res);

        return res;
    }
}


    



