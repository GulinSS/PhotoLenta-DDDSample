using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;
using GulinSerge.PhotoLenta.Domain.Services;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Services
{
	public class GalleryImpl : Gallery
	{
		private ImageLinkRepository Repository { get; set; }

		public GalleryImpl(ImageLinkRepository repository)
		{
			Repository = repository;
		}

		public IEnumerableSegment<ImageLink> Content(long pageNumber, Tag tag, FilterOrderType order)
		{
			return 
				Repository.Specification()
					.Tag(tag)
					.OrderType(order)
					.Page(pageNumber)
				.Execute();
		}

		public IEnumerable<ImageLink> Updates(DateTime time, Tag tag, FilterOrderType order)
		{
			return
				Repository.Specification()
					.Tag(tag)
					.MaxDateTime(time)
					.OrderType(order)
				.Execute();
		}

		public IEnumerable<Tag> TagsKnown()
		{
			throw new NotImplementedException();
		}
	}
}
