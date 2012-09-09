using System.Collections.Generic;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Repositories
{
	public interface UserRepository : Repository<User, object>
	{
		User GetByIC(IdentityCard card);
	}
}