using System;
using System.Collections.Generic;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// ������ �� ���������� ������ �� ��������, �.�. Ajax
	/// </summary>
	public class GalleryRefreshRequest
	{
		public GalleryRefreshRequest(DateTime stamp, IEnumerable<PhotoLink> photos, LentaPage lentaPage)
		{
			Stamp = stamp;
			Photos = photos;
			LentaPage = lentaPage;
		}

		/// <summary>
		/// ����� �������, �� �������� �������� �������
		/// </summary>
		public DateTime Stamp { get; private set; }

		/// <summary>
		/// ������ ��������� �������� ��� ��� ������������ �����������
		/// </summary>
		public IEnumerable<PhotoLink> Photos { get; private set; }

		/// <summary>
		/// ���������� � ������� �������� ��������
		/// </summary>
		public LentaPage LentaPage { get; private set; }
	}
}