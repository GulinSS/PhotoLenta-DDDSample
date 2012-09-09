using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.Services;

namespace GulinSerge.PhotoLenta.Web.View.Controllers
{
	public class PhotoController : Controller
	{
		private readonly WebPhoto _photo;

		public PhotoController(WebPhoto photo)
		{
			_photo = photo;
		}

		public ActionResult Thumbnail(PhotoLink link)
		{
			var thumb = _photo.GetThumbnail(link);
			return new FileStreamResult(thumb.Stream, thumb.Type.ToString());
		}

		public ActionResult Full(PhotoLink link)
		{
			var photo = _photo.GetThumbnail(link);
			return new FileStreamResult(photo.Stream, photo.Type.ToString());
		}
	}
}