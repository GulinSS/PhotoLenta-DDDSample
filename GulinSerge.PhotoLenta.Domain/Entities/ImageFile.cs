using System.IO;
using System.Net.Mime;
using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface ImageFile : Entity
	{
		Stream Stream { get; }
		ContentType ContentType { get; }
	}
}