using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.Services;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Stubs
{
	public class WebPhotoImpl : WebPhoto
	{
		private const string THUMBLINK = "http://placehold.it/260x180";
		private const string PHOTOLINK = "http://placehold.it/1024x768";

		public PhotoFile GetPhoto(PhotoLink link)
		{
			WebRequest request = WebRequest.Create(PHOTOLINK);
			var response = request.GetResponse();
			var stream = response.GetResponseStream();
			return new PhotoFile(stream, response.ContentType);
		}

		public PhotoFile GetThumbnail(PhotoLink link)
		{
			WebRequest request = WebRequest.Create(THUMBLINK);
			var response = request.GetResponse();
			var stream = response.GetResponseStream();
			return new PhotoFile(stream, response.ContentType);
		}
	}
}
