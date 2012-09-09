using System.IO;
using System.Net.Mime;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages
{
	/// <summary>
	/// ���� ����������
	/// </summary>
	public class PhotoFile
	{
		public PhotoFile(Stream stream, string type)
		{
			Stream = stream;
			Type = new ContentType(type);
		}

		public PhotoFile(Stream stream)
		{
			Stream = stream;
			Type = new ContentType("image/jpeg");
		}

		/// <summary>
		/// ������
		/// </summary>
		public Stream Stream { get; private set; }

		/// <summary>
		/// ��� ��������
		/// </summary>
		public ContentType Type { get; private set; }
	}
}