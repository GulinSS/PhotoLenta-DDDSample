namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ��������
	/// </summary>
	public class Paging
	{
		public Paging(int minCurrentPage, int maxCurrentPage)
		{
			MinCurrentPage = minCurrentPage;
			MaxCurrentPage = maxCurrentPage;
		}

		/// <summary>
		/// ����� ������ �������� �� ������
		/// </summary>
		public int MinCurrentPage { get; private set; }

		/// <summary>
		/// ����� ��������� �������� �� ������
		/// </summary>
		public int MaxCurrentPage { get; private set; }

		//public int AllPages { get; private set; }
	}
}