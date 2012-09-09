using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Services;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.Responses;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Stubs
{
	internal class GalleryLoadResponseBuilder
	{
		private static PagingState BuildPaging()
		{
			return new PagingState(1, 5, 1);
		}

		private static IEnumerable<Thumbnail> BuildThumbs()
		{
			return 
				new List<Thumbnail>()
					{
						new Thumbnail(0, BuildLink(), true, BuildUser()),
						new Thumbnail(1, BuildLink(), false, BuildUser()),
						new Thumbnail(2, BuildLink(), true, BuildUser()),
						new Thumbnail(0, BuildLink(), true, BuildUser()),
						new Thumbnail(2, BuildLink(), false, BuildUser()),
						new Thumbnail(2, BuildLink(), false, BuildUser()),
						new Thumbnail(5, BuildLink(), true, BuildUser()),
						new Thumbnail(1, BuildLink(), false, BuildUser()),

					};
		}
		
		private static ThumbnailUser BuildUser()
		{
			return new ThumbnailUser("http://www.gravatar.com/avatar/00000000000000000000000000000000?d=mm&s=40");
		}

		private static PhotoLink BuildLink()
		{
			return new PhotoLink(0);
		}

		private static TagMenuState BuildMenu()
		{
			return new TagMenuState(20, new[] {new TagWeb("Пейзаж", 10), new TagWeb("Портрет", 5)});
		}

		public static GalleryLoadResponse Build()
		{
			return new GalleryLoadResponse(BuildPaging(), BuildThumbs(), BuildMenu(), FilterOrderType.ByTime);
		}
	}
}
