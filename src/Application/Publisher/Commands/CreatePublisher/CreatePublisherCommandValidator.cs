using Application.Common.Interfaces;
using FluentValidation;

namespace Application.Publisher.Commands.CreatePublisher;

public class CreatePublisherCommandValidator : AbstractValidator<CreatePublisherCommand>
{
	private readonly IApplicationDbContext _context;
	public CreatePublisherCommandValidator(IApplicationDbContext context)
	{
		_context = context;

		
		
	}
}
