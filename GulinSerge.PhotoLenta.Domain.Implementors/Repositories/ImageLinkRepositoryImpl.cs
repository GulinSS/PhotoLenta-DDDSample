using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;
using GulinSerge.PhotoLenta.Domain.Services;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Repositories
{
	public class ImageLinkRepositoryImpl : ImageLinkRepository
	{
		private readonly KeyValueProvider<ImageLink, long> _provider;
		private readonly KeyValueProvider<Tag, long> _tagProvider;
		private readonly QueryableProvider _queryableProvider;

		public ImageLinkRepositoryImpl(KeyValueProvider<ImageLink, long> provider, KeyValueProvider<Tag, long> tagProvider, QueryableProvider queryableProvider)
		{
			_provider = provider;
			_tagProvider = tagProvider;
			_queryableProvider = queryableProvider;
		}

		public void Remove(ImageLink o)
		{
			_provider.Delete(o);
		}

		public void Put(ImageLink o)
		{
			_provider.Put(o);
		}

		/// <summary>
		/// TODO: компонент по тегам
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		public IEnumerable<Tag> MergeTags(IEnumerable<Tag> tags)
		{
			//Конвертация
			tags = tags.Select(TagImpl.BuildFromTag).ToList();
			
			//Поиск существующих
			IEnumerable<string> tagNames = tags.Select(x => x.DisplayName).AsEnumerable();
			
			//Инкрементация
			var q = _queryableProvider.Linq<Tag>().Where(x => tagNames.Contains(x.DisplayName)).ToList();
			foreach (Tag tag in q)
			{
				tag.IncrementWeight();
				_tagProvider.Put(tag);
			}
			
			//Добавление новых
			var sTags = tags.Except(q).ToList();
			foreach (Tag sTag in sTags)
			{
				_tagProvider.Put(sTag);
			}
			return sTags.Union(q);
		}

		public int VoteCount(ImageLink link)
		{
			return _queryableProvider.Linq<UserVote>().Count(x => x.ImageLink == link);
		}

		public ImageLink this[long key]
		{
			get { return _provider.Get(key); }
		}

		public ImageLinkSpecification Specification()
		{
			return new ImageLinkSpecificationImpl(_queryableProvider.Linq<ImageLinkImpl>());
		}
	}

	public class ImageLinkSpecificationImpl : ImageLinkSpecification
	{
		private const int PAGE_ELEMENT_COUNT = 9;

		private readonly IQueryable<ImageLink> _queryable;

		public ImageLinkSpecificationImpl(IQueryable<ImageLink> queryable)
		{
			_queryable = queryable;
		}

		public IEnumerable<ImageLink> Execute()
		{
			return _queryable.ToArray();
		}

		public SpecificationPaged<ImageLink> Segment(int skip, int take)
		{
			return new ImageLinkSpecificationPagedImpl(_queryable.Skip(skip).Take(take));
		}

		public SpecificationPaged<ImageLink> Page(long pageNumber)
		{
			return Segment((int)(PAGE_ELEMENT_COUNT*pageNumber), PAGE_ELEMENT_COUNT);
		}

		public ImageLinkSpecification Tag(Tag tag)
		{
			return new ImageLinkSpecificationImpl(_queryable.Where(x => x.Tags.Contains(tag)));
		}

		public ImageLinkSpecification OrderType(FilterOrderType orderType)
		{
			switch (orderType)
			{
				case FilterOrderType.ByTime:
					return new ImageLinkSpecificationImpl(_queryable.OrderByDescending(x => x.DateCreate));
				case FilterOrderType.ByRating:
					//TODO: перенести вычисление на БД
					return new ImageLinkSpecificationImpl(_queryable.OrderBy(x => x.Votes));
				default:
					throw new ArgumentOutOfRangeException("orderType");
			}
		}

		public ImageLinkSpecification MaxDateTime(DateTime dateTime)
		{
			return new ImageLinkSpecificationImpl(_queryable.Where(x => x.DateCreate > dateTime));
		}
	}

	public class ImageLinkSpecificationPagedImpl : SpecificationPaged<ImageLink>
	{
		private readonly IQueryable<ImageLink> _queryable; 

		public ImageLinkSpecificationPagedImpl(IQueryable<ImageLink> take)
		{
			_queryable = take;
		}

		public IEnumerableSegment<ImageLink> Execute()
		{
			var count = _queryable.Count();
			return new EnumerableSegment<ImageLink>(_queryable.ToArray(), count);
		}
	}
}
