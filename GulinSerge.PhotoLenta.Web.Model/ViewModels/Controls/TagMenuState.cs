using System.Collections.Generic;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Меню тегов с состоянием
	/// </summary>
	public class TagMenuState : TagMenu
	{
		public TagMenuState(int allCount, IEnumerable<TagWeb> tags, TagWeb currentTagWeb) : base(allCount, tags)
		{
			CurrentTagWeb = currentTagWeb;
		}

		public TagMenuState(int allCount, IEnumerable<TagWeb> tags) : base(allCount, tags)
		{
			CurrentTagWeb = null;
		}

		/// <summary>
		/// Если Null, значит "Все"
		/// </summary>
		public TagWeb CurrentTagWeb { get; private set; }
	}
}