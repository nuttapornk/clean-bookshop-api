using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Publishers.Commands.CreatePublisher;

public record CreatePublisherCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
}

public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommand, int>
{
    private readonly IApplicationDbContext _context;
    public CreatePublisherCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreatePublisherCommand request, CancellationToken cancellationToken)
    {
        var entity = new Publisher
        {
            Name = request.Name,
            Status = 1,
            TimeInsert = DateTime.Now,
            TimeUpdate = DateTime.Now,
        };

        entity.AddDomainEvent(new PublisherCreatedEvent(entity));

        _context.Publishers.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);
        return entity.Id;

    }
}
