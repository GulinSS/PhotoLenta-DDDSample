using System;
using System.Collections.Generic;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class UserImpl : EntityBase, User
	{
		private KeyValueProvider<UserVote, long> _userVoteProvider;
		private ImageLinkRepository _linkRepository;

		protected UserImpl()
		{
		}

		public UserImpl(string avatarUrl, IdentityCard card)
		{
			AvatarUrl = avatarUrl;
			Card = card;
		}

		public string AvatarUrl { get; protected set; }

		public IdentityCard Card { get; protected set; }

		public void BePaid()
		{
			throw new NotImplementedException();
		}

		public void Publish(IEnumerable<Tag> tags, ImageFile file)
		{
			tags = _linkRepository.MergeTags(tags);
			ImageLink link = new ImageLinkImpl(this, file, tags);
			_linkRepository.Put(link);
		}

		public void IncrementRating(ImageLink imageLink)
		{
			_userVoteProvider.Put(new UserVoteImpl(this, imageLink));
		}
	}
}