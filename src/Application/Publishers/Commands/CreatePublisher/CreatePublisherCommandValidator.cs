using FluentValidation;

namespace Application.Publishers.Commands.CreatePublisher;

public class CreatePublisherCommandValidator : AbstractValidator<CreatePublisherCommand>
{
	public CreatePublisherCommandValidator()
	{
		RuleFor(v => v.Name).NotEmpty().MaximumLength(100);
	}
}
