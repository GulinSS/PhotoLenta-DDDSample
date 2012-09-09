using FluentNHibernate.Mapping;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class UserMap : BaseMap<UserImpl>
	{
		public UserMap()
		{
			Table("Users");
			Map(x => x.AvatarUrl);

			References(x => x.Card).Class<IdentityCardLocalImpl>().Cascade.All().Not.Nullable();
		}
	}
}