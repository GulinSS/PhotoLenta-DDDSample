using GulinSerge.PhotoLenta.Web.Model.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на увеличение рейтинга фотографии
	/// </summary>
	public class RatingIncrementRequest
	{
		public RatingIncrementRequest(PhotoLink link)
		{
			Photo = link;
		}

		/// <summary>
		/// Идентификатор изображения. TODO: придумать что-то получше для ключа
		/// </summary>
		public PhotoLink Photo { get; private set; }
	}
}