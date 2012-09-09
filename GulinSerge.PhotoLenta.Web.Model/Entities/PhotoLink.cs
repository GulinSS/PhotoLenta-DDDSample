namespace GulinSerge.PhotoLenta.Web.Model.Entities
{
	/// <summary>
	/// Ссылка на фотографию.
	/// </summary>
	public class PhotoLink
	{
		public PhotoLink(long id)
		{
			ID = id;
		}

		/// <summary>
		/// Ключ фотографии
		/// </summary>
		public long ID { get; private set; }
	}
}