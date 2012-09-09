using System;
using System.Linq;

namespace GulinSerge.Common
{
	public interface QueryableProvider
	{
		IQueryable<T> Linq<T>();
	}

	public interface KeyValueProvider<T, in TKey>
	{
		T Get(TKey key, LazyLoad load = LazyLoad.Aggressive);
		void Delete(T o);
		void Put(T o);
	}
}