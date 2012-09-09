using System.Collections.Generic;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// ������ �� ���������� ����������
	/// </summary>
	public class PhotoPublishRequest
	{
		/// <summary>
		/// ���� �����������
		/// </summary>
		public PhotoFile File { get; private set; }

		/// <summary>
		/// ���� (� �����, � ��� ���������)
		/// </summary>
		public IEnumerable<TagWeb> Tags { get; private set; }
	}
}