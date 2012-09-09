using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Services;
using GulinSerge.PhotoLenta.Web.View.Extensions;

namespace GulinSerge.PhotoLenta.Web.View.Controllers
{
	public class GalleryController : Controller
	{
		public WebLenta Lenta { get; private set; }

		public GalleryController(WebLenta lenta)
		{
			Lenta = lenta;
		}

		public ActionResult Publish(PhotoPublishRequest request)
		{
			return Lenta.PublishPhoto(request).ToJson();
		}

		public ActionResult Increment(RatingIncrementRequest request)
		{
			return Lenta.IncrementRating(request).ToJson();
		}

		public ActionResult Index(GalleryLoadRequest request)
		{
			return View(Lenta.LoadGallery(request));
		}

		public ActionResult Refresh(GalleryRefreshRequest request)
		{
			return Lenta.RefreshGallery(request).ToJson();
		}
	}
}