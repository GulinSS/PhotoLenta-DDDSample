using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Responses;

namespace GulinSerge.PhotoLenta.Web.Model.Services
{
	/// <summary>
	/// Фасад управления Лентой
	/// </summary>
	public interface WebLenta
	{
		/// <summary>
		/// Загрузить страницу с фотографиями
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		GalleryLoadResponse LoadGallery(GalleryLoadRequest request);
		
		/// <summary>
		/// Обновить текущую страницу с фотографиями
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		GalleryRefreshResponse RefreshGallery(GalleryRefreshRequest request);
		
		/// <summary>
		/// Опубликовать фото
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		PhotoPublishResponse PublishPhoto(PhotoPublishRequest request);
		
		/// <summary>
		/// Увеличить рейтинг фотографии
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		RatingIncrementResponse IncrementRating(RatingIncrementRequest request);
	}
}
