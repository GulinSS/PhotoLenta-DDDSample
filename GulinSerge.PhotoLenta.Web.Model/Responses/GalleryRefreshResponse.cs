using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;

namespace GulinSerge.PhotoLenta.Web.Model.Responses
{
	public class GalleryRefreshResponse
	{
		public IEnumerable<Thumbnail> Thumbnails { get; private set; }

		/// <summary>
		/// Меню тегов
		/// </summary>
		public TagMenu Tags { get; private set; }
	}
}
