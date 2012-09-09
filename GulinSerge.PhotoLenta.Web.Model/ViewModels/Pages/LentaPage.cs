using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Services;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages
{
	/// <summary>
	/// Состояние главной страницы
	/// </summary>
	public class LentaPage
	{
		/// <summary>
		/// Полная фильтрация
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
		/// Отображение всех с учетом пейджинга и порядка сортировки
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
		/// Только что открыли страницу ленты
		/// </summary>
		public LentaPage()
		{
			OrderType = FilterOrderType.ByTime;
			TagWeb = null;
		}

		/// <summary>
		/// Тип упорядочивания
		/// </summary>
		public FilterOrderType OrderType { get; private set; }

		/// <summary>
		/// Фильтр по тегу, если Null, значит показывать все.
		/// </summary>
		public TagWeb TagWeb { get; private set; }

		/// <summary>
		/// Номер страницы
		/// </summary>
		public int Page { get; private set; }
	}
}