using Domain.Common;
using Domain.Entities;

namespace Domain.Events;

public class PublisherCreatedEvent : BaseEvent
{
    public Publisher Item { get; }

    public PublisherCreatedEvent(Publisher item)
	{
		Item = item;
	}	
}
