using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Services;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Responses
{
	public class GalleryLoadResponse
	{
		public GalleryLoadResponse(PagingState paging, IEnumerable<Thumbnail> thumbnails, TagMenuState tags, FilterOrderType filterOrder)
		{
			Paging = paging;
			Thumbnails = thumbnails;
			Tags = tags;
			FilterOrder = filterOrder;
		}

		/// <summary>
		/// Постраничная навигация
		/// </summary>
		public PagingState Paging { get; private set; }

		/// <summary>
		/// Фотографии на странице
		/// </summary>
		public IEnumerable<Thumbnail> Thumbnails { get; private set; }

		/// <summary>
		/// Меню тегов
		/// </summary>
		public TagMenuState Tags { get; private set; }

		/// <summary>
		/// Порядок фильтрации
		/// </summary>
		public FilterOrderType FilterOrder { get; private set; }
	}
}
