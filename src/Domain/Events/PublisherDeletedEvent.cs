using Domain.Entities;

namespace Domain.Events;

public class PublisherDeletedEvent
{
    public Publisher Item { get; }

    public PublisherDeletedEvent(Publisher item)
	{
        Item = item;
	}	
}
