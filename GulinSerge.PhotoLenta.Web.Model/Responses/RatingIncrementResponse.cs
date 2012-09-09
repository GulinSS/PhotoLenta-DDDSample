using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;

namespace GulinSerge.PhotoLenta.Web.Model.Responses
{
	/// <summary>
	/// Ответ на изменение рейтинга
	/// </summary>
	public class RatingIncrementResponse
	{
		/// <summary>
		/// Фотография
		/// </summary>
		public Thumbnail Thumbnail { get; private set; }
	}
}