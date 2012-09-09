using GulinSerge.PhotoLenta.Web.Model.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Фотография в галерее
	/// </summary>
	public class Thumbnail
	{
		public Thumbnail(long rating, PhotoLink link, bool canIncrement, ThumbnailUser user)
		{
			Rating = rating;
			Link = link;
			CanIncrement = canIncrement;
			User = user;
		}

		/// <summary>
		/// Идентификатор фотографии
		/// </summary>
		public PhotoLink Link { get; private set; }

		/// <summary>
		/// Количество лайков
		/// </summary>
		public long Rating { get; private set; }

		/// <summary>
		/// Может ли пользователь повлиять на рейтинг
		/// </summary>
		public bool CanIncrement { get; private set; }

		/// <summary>
		/// Информация о публикаторе
		/// </summary>
		public ThumbnailUser User { get; private set; }
	}
}