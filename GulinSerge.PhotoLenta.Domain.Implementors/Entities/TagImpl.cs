using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class TagImpl : EntityBase, Tag
	{
		protected TagImpl()
		{
		}

		public TagImpl(string displayName, long weight)
		{
			DisplayName = displayName;
			Weight = weight;
		}

		public string DisplayName { get; protected set; }

		public long Weight { get; protected set; }

		public void IncrementWeight()
		{
			Weight++;
		}

		/// <summary>
		/// TODO: вынести в конвертер
		/// </summary>
		/// <param name="tag"></param>
		/// <returns></returns>
		public static Tag BuildFromTag(Tag tag)
		{
			return new TagImpl(tag.DisplayName.ToLower(), 1);
		}
	}
}