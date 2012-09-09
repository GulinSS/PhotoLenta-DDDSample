using GulinSerge.PhotoLenta.Web.Model.Entities;

namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// ������ �� ���������� �������� ����������
	/// </summary>
	public class RatingIncrementRequest
	{
		public RatingIncrementRequest(PhotoLink link)
		{
			Photo = link;
		}

		/// <summary>
		/// ������������� �����������. TODO: ��������� ���-�� ������� ��� �����
		/// </summary>
		public PhotoLink Photo { get; private set; }
	}
}