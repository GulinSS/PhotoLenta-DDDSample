namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ���������� ���������
	/// </summary>
	public class ThumbnailUser
	{
		public ThumbnailUser(string imageUrl)
		{
			AvatarUrl = imageUrl;
		}

		/// <summary>
		/// Url-����� ��������
		/// http://www.gravatar.com/avatar/00000000000000000000000000000000?d=mm&s=40
		/// </summary>
		public string AvatarUrl { get; private set; }
	}
}
