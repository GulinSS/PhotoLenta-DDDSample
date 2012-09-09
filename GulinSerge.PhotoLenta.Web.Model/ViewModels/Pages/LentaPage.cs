using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Services;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages
{
	/// <summary>
	/// ��������� ������� ��������
	/// </summary>
	public class LentaPage
	{
		/// <summary>
		/// ������ ����������
		/// </summary>
		/// <param name="orderType"></param>
		/// <param name="tagWeb"></param>
		/// <param name="page"></param>
		public LentaPage(FilterOrderType orderType, TagWeb tagWeb, int page)
		{
			OrderType = orderType;
			TagWeb = tagWeb;
			Page = page;
		}

		/// <summary>
		/// ����������� ���� � ������ ��������� � ������� ����������
		/// </summary>
		/// <param name="orderType"></param>
		/// <param name="page"></param>
		public LentaPage(FilterOrderType orderType, int page)
		{
			OrderType = orderType;
			Page = page;
			TagWeb = null;
		}

		/// <summary>
		/// ������ ��� ������� �������� �����
		/// </summary>
		public LentaPage()
		{
			OrderType = FilterOrderType.ByTime;
			TagWeb = null;
		}

		/// <summary>
		/// ��� ��������������
		/// </summary>
		public FilterOrderType OrderType { get; private set; }

		/// <summary>
		/// ������ �� ����, ���� Null, ������ ���������� ���.
		/// </summary>
		public TagWeb TagWeb { get; private set; }

		/// <summary>
		/// ����� ��������
		/// </summary>
		public int Page { get; private set; }
	}
}