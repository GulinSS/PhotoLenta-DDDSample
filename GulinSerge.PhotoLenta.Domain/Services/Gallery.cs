using System;
using System.Collections.Generic;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Services
{
	public interface Gallery
	{
		IEnumerableSegment<ImageLink> Content(long pageNumber, Tag tag, FilterOrderType order);
		IEnumerable<ImageLink> Updates(DateTime time, Tag tag, FilterOrderType order);
		IEnumerable<Tag> TagsKnown();
	}
}