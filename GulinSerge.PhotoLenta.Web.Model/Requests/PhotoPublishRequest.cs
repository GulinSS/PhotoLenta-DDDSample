using System.Collections.Generic;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на публикацию фотографии
	/// </summary>
	public class PhotoPublishRequest
	{
		/// <summary>
		/// Файл изображения
		/// </summary>
		public PhotoFile File { get; private set; }

		/// <summary>
		/// Теги (и новые, и уже известные)
		/// </summary>
		public IEnumerable<TagWeb> Tags { get; private set; }
	}
}