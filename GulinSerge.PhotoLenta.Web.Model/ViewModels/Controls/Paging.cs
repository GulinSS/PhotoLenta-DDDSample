namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Пейджинг
	/// </summary>
	public class Paging
	{
		public Paging(int minCurrentPage, int maxCurrentPage)
		{
			MinCurrentPage = minCurrentPage;
			MaxCurrentPage = maxCurrentPage;
		}

		/// <summary>
		/// Номер первой страницы из набора
		/// </summary>
		public int MinCurrentPage { get; private set; }

		/// <summary>
		/// Номер последней страницы из набора
		/// </summary>
		public int MaxCurrentPage { get; private set; }

		//public int AllPages { get; private set; }
	}
}