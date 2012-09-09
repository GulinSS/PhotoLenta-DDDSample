using System.IO;
using System.Net.Mime;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages
{
	/// <summary>
	/// Файл фотографии
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
		/// Данные
		/// </summary>
		public Stream Stream { get; private set; }

		/// <summary>
		/// Тип контента
		/// </summary>
		public ContentType Type { get; private set; }
	}
}