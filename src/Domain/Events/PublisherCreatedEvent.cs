using Domain.Common;
using Domain.Entities;

namespace Domain.Events;

public class PublisherCreatedEvent : BaseEvent
{
	public PublisherCreatedEvent(Publisher item)
	{
		Item = item;
	}

	public Publisher Item { get; }
}
