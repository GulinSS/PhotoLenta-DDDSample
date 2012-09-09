namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Публикатор фотографи
	/// </summary>
	public class ThumbnailUser
	{
		public ThumbnailUser(string imageUrl)
		{
			AvatarUrl = imageUrl;
		}

		/// <summary>
		/// Url-адрес аватарки
		/// http://www.gravatar.com/avatar/00000000000000000000000000000000?d=mm&s=40
		/// </summary>
		public string AvatarUrl { get; private set; }
	}
}
