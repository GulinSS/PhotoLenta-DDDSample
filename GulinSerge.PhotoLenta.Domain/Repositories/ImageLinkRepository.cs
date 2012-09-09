using System;
using System.Collections.Generic;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Services;

namespace GulinSerge.PhotoLenta.Domain.Repositories
{
	public interface ImageLinkRepository : Repository<ImageLink, long, ImageLinkSpecification>
	{
		int VoteCount(ImageLink link);
		IEnumerable<Tag> MergeTags(IEnumerable<Tag> tags);
	}

	public interface ImageLinkSpecification : Specification<ImageLink>
	{
		ImageLinkSpecification Tag(Tag tag);
		ImageLinkSpecification OrderType(FilterOrderType orderType);
		ImageLinkSpecification MaxDateTime(DateTime dateTime);
	}
}