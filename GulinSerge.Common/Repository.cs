using System.Collections.Generic;

namespace GulinSerge.Common
{
	public interface Repository<T, in TKey>
		where T : AggregateRoot 
	{
		void Remove(T o);
		void Put(T o);
		T this[TKey key] { get; }
	}

	public interface Repository<T, in TKey, out TRootSpecification> : Repository<T, TKey>
		where T : AggregateRoot
		where TRootSpecification : Specification<T>
	{
		TRootSpecification Specification();
	}

}