using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// ������ �� ����������� ��������
	/// </summary>
	public class GalleryLoadRequest
	{
		public GalleryLoadRequest(LentaPage pageState)
		{
			PageState = pageState;
		}

		/// <summary>
		/// ������������� ���������
		/// </summary>
		public LentaPage PageState { get; private set; }
	}
}