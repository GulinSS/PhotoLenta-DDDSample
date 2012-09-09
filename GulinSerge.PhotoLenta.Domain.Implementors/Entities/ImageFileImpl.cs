using System.IO;
using System.Net.Mime;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class ImageFileImpl : EntityBase, ImageFile
	{
		protected ImageFileImpl()
		{
		}

		public ImageFileImpl(Stream stream, ContentType contentType)
		{
			Stream = stream;
			ContentType = contentType;
		}

		public Stream Stream { get; protected set; }

		public ContentType ContentType { get; protected set; }
	}
}