using GulinSerge.Common;
using FluentNHibernate.Mapping;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class BaseMap<TEntity> : ClassMap<TEntity>
		where TEntity : EntityBase
	{
		protected BaseMap()
		{
			// ReSharper disable DoNotCallOverridableMethodsInConstructor
			Id(x => x.Id);
			// ReSharper restore DoNotCallOverridableMethodsInConstructor

			DynamicInsert();
			DynamicUpdate();
		}
	}
}