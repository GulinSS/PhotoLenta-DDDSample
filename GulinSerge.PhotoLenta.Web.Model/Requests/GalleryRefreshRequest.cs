using System;
using System.Collections.Generic;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на обновление данных на странице, д.б. Ajax
	/// </summary>
	public class GalleryRefreshRequest
	{
		public GalleryRefreshRequest(DateTime stamp, IEnumerable<PhotoLink> photos, LentaPage lentaPage)
		{
			Stamp = stamp;
			Photos = photos;
			LentaPage = lentaPage;
		}

		/// <summary>
		/// Штамп времени, от которого показать разницу
		/// </summary>
		public DateTime Stamp { get; private set; }

		/// <summary>
		/// Запрос изменения рейтинга для уже отображаемых изображений
		/// </summary>
		public IEnumerable<PhotoLink> Photos { get; private set; }

		/// <summary>
		/// Информация о текущей открытой странице
		/// </summary>
		public LentaPage LentaPage { get; private set; }
	}
}