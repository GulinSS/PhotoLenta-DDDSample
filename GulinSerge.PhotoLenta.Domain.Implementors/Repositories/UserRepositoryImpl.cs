using System;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;
using System.Linq;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Repositories
{
	public class UserRepositoryImpl : UserRepository
	{
		private readonly KeyValueProvider<User, object> _provider;
		private readonly QueryableProvider _queryableProvider;

		public UserRepositoryImpl(KeyValueProvider<User, object> provider, QueryableProvider queryableProvider)
		{
			_provider = provider;
			_queryableProvider = queryableProvider;
		}

		public void Remove(User o)
		{
			_provider.Delete(o);
		}

		public void Put(User o)
		{
			_provider.Put(o);
		}

		public User this[object key]
		{
			get { return _provider.Get(key); }
		}

		public User GetByIC(IdentityCard card)
		{
			return _queryableProvider.Linq<User>().FirstOrDefault(x => x.Card.IdentityKey == card.IdentityKey);
		}
	}
}