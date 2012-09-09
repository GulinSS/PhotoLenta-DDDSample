using System;
using System.Collections.Generic;
using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface ImageLink : Entity, AggregateRoot
	{
		User Publisher { get; }
		ImageFile File { get; }
		DateTime DateCreate { get; }

		IEnumerable<Tag> Tags { get; }

		long Votes { get; }
	}
}