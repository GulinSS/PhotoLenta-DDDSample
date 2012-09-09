using System.Collections.Generic;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ���� �����, ������ ������ � ��������� "���"
	/// </summary>
	public class TagMenu
	{
		public TagMenu(int allCount, IEnumerable<TagWeb> tags)
		{
			AllCount = allCount;
			Tags = tags;
		}

		/// <summary>
		/// ���������� ��� "����"
		/// </summary>
		public int AllCount { get; private set; }

		public IEnumerable<TagWeb> Tags { get; private set; }
	}
}