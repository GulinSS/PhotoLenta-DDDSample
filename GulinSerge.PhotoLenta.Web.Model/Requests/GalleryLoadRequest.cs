using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на отображение страницы
	/// </summary>
	public class GalleryLoadRequest
	{
		public GalleryLoadRequest(LentaPage pageState)
		{
			PageState = pageState;
		}

		/// <summary>
		/// Запрашиваемое состояние
		/// </summary>
		public LentaPage PageState { get; private set; }
	}
}