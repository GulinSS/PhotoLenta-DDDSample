using System.Collections.Generic;
using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface User : Entity, AggregateRoot
	{
		string AvatarUrl { get; }
		IdentityCard Card { get; }
		
		void BePaid();
		void Publish(IEnumerable<Tag> tags, ImageFile file);
		void IncrementRating(ImageLink imageLink);
	}
}