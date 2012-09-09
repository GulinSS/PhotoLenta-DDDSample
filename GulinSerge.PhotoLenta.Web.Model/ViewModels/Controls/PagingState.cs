namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	public class PagingState : Paging
	{
		public PagingState(int minCurrentPage, int maxCurrentPage, int currentPage) : base(minCurrentPage, maxCurrentPage)
		{
			CurrentPage = currentPage;
		}

		/// <summary>
		/// ����� ������� ��������
		/// </summary>
		public int CurrentPage { get; private set; }
	}
}