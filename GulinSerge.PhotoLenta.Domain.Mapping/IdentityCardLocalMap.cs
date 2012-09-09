using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;
using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace GulinSerge.PhotoLenta.Domain.Mapping
{
	public class IdentityCardLocalMap : BaseMap<IdentityCardLocalImpl>
	{
		public IdentityCardLocalMap()
		{
			Table("IdentityCards");
			Map(x => x.EMail).Unique().Not.Nullable();
			Map(x => x.Password).Not.Nullable();
		}
	}
}
