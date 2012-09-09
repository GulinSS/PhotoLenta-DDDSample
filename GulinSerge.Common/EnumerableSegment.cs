using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GulinSerge.Common
{
	public interface IEnumerableSegment<out T> : IEnumerable<T>
	{
		long FullCount { get; }
		long SegmentCount { get; }
	}

	public class EnumerableSegment<T> : IEnumerableSegment<T>
	{
		private readonly T[] _list;
		public long FullCount { get; private set; }
		public long SegmentCount { get { return _list.Length; } }

		public EnumerableSegment(T[] list, long fullCount)
		{
			_list = list;
			FullCount = fullCount;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _list.AsEnumerable().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public static class EnumerableSegmentExtensions
	{
		public static EnumerableSegment<T> AsSegment<T>(IQueryable<T> queryable, int skip, int take)
		{
			long full = queryable.LongCount();
			return new EnumerableSegment<T>(queryable.Skip(skip).Take(take).ToArray(), full);
		}
	}

	public interface SpecificationPaged<out T>
	{
		IEnumerableSegment<T> Execute();
	}

	public interface SpecificationEnd<out T>
	{
		IEnumerable<T> Execute();
	}

	public interface Specification<out T> : SpecificationEnd<T>
	{
		SpecificationPaged<T> Segment(int skip, int take);
		SpecificationPaged<T> Page(long pageNumber = 0);
	}
}
