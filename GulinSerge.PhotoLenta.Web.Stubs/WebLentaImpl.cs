using System;
using System.Linq;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;
using GulinSerge.PhotoLenta.Domain.Services;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Responses;
using GulinSerge.PhotoLenta.Web.Model.Services;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Stubs
{
	public class WebLentaImpl : WebLenta
	{
		private readonly Gallery _gallery;

		public WebLentaImpl(Gallery gallery)
		{
			_gallery = gallery;
		}

		public GalleryLoadResponse LoadGallery(GalleryLoadRequest request)
		{
			var result = _gallery.Content(request.PageState.Page, request.PageState.TagWeb, request.PageState.OrderType);
			throw new NotImplementedException();
		}

		public GalleryRefreshResponse RefreshGallery(GalleryRefreshRequest request)
		{
			throw new NotImplementedException();
		}

		public PhotoPublishResponse PublishPhoto(PhotoPublishRequest request)
		{
			throw new NotImplementedException();
		}

		public RatingIncrementResponse IncrementRating(RatingIncrementRequest request)
		{
			throw new NotImplementedException();
		}
	}
}