using FluentNHibernate.Mapping;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class TagMap : BaseMap<TagImpl>
	{
		public TagMap()
		{
			Table("Tags");
			Map(x => x.DisplayName).Unique().Not.Nullable();
			Map(x => x.Weight).Not.Nullable();
		}
	}
}