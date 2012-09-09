using GulinSerge.PhotoLenta.Domain.Implementors.Entities;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class ImageFileMap : BaseMap<ImageFileImpl>
	{
		public ImageFileMap()
		{
			Table("ImageFiles");
			Map(x => x.Stream);
			Map(x => x.ContentType);
		}
	}
}