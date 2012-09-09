using GulinSerge.PhotoLenta.Web.Model.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ���������� � �������
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
		/// ������������� ����������
		/// </summary>
		public PhotoLink Link { get; private set; }

		/// <summary>
		/// ���������� ������
		/// </summary>
		public long Rating { get; private set; }

		/// <summary>
		/// ����� �� ������������ �������� �� �������
		/// </summary>
		public bool CanIncrement { get; private set; }

		/// <summary>
		/// ���������� � �����������
		/// </summary>
		public ThumbnailUser User { get; private set; }
	}
}