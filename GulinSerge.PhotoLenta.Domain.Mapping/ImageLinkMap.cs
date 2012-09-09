using FluentNHibernate.Mapping;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class ImageLinkMap : BaseMap<ImageLinkImpl>
	{
		public ImageLinkMap()
		{
			Table("ImageLinks");
			Map(x => x.DateCreate).Not.Nullable();

			References(x => x.File).Class<ImageFileImpl>().Cascade.All().LazyLoad(Laziness.Proxy).Not.Nullable();
			References(x => x.Publisher).Class<UserImpl>().Cascade.None().Not.Nullable();

			HasMany(x => x.Tags).Cascade.None();
		}
	}
}