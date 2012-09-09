using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ���
	/// </summary>
	public class TagWeb : Tag
	{
		public TagWeb(string displayName, long weight)
		{
			DisplayName = displayName;
			Weight = weight;
		}

		/// <summary>
		/// ������������ ���
		/// </summary>
		public string DisplayName { get; private set; }

		/// <summary>
		/// ���
		/// </summary>
		public long Weight { get; private set; }

		public void IncrementWeight()
		{
			throw new System.NotSupportedException();
		}
	}
}