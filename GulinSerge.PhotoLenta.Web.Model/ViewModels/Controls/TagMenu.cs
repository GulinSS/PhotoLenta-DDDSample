using System.Collections.Generic;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Меню тегов, особый случай с элементом "Все"
	/// </summary>
	public class TagMenu
	{
		public TagMenu(int allCount, IEnumerable<TagWeb> tags)
		{
			AllCount = allCount;
			Tags = tags;
		}

		/// <summary>
		/// Количество для "Всех"
		/// </summary>
		public int AllCount { get; private set; }

		public IEnumerable<TagWeb> Tags { get; private set; }
	}
}