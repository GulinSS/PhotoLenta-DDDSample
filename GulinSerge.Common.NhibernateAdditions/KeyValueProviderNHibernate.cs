using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Linq;

namespace GulinSerge.Common.NhibernateAdditions
{
	public class QueryableProviderNHibernate : QueryableProvider
	{
		private readonly ISession _session;

		public QueryableProviderNHibernate(ISession session)
		{
			_session = session;
		}

		public IQueryable<T> Linq<T>()
		{
			return _session.Query<T>();
		}
	}

	public class KeyValueProviderNHibernate<T, TKey> : KeyValueProvider<T, TKey>
	{
		private readonly ISession _session;

		public KeyValueProviderNHibernate(ISession session)
		{
			_session = session;
		}

		public T Get(TKey key, LazyLoad load)
		{
			switch (load)
			{
				case LazyLoad.Aggressive:
					return _session.Load<T>(key);
				case LazyLoad.Normal:
					return _session.Get<T>(key);
				default:
					throw new ArgumentOutOfRangeException("load");
			}
		}

		public void Delete(T o)
		{
			_session.Delete(o);
		}

		public void Put(T o)
		{
			_session.SaveOrUpdate(o);
		}
	}
}
