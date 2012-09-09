using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// Тег
	/// </summary>
	public class TagWeb : Tag
	{
		public TagWeb(string displayName, long weight)
		{
			DisplayName = displayName;
			Weight = weight;
		}

		/// <summary>
		/// Отображаемое имя
		/// </summary>
		public string DisplayName { get; private set; }

		/// <summary>
		/// Вес
		/// </summary>
		public long Weight { get; private set; }

		public void IncrementWeight()
		{
			throw new System.NotSupportedException();
		}
	}
}