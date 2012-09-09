using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class ImageLinkImpl : EntityBase, ImageLink, ISerializable
	{
		private ImageLinkRepository _repository;
		
		private IList<Tag> _tags;

		protected ImageLinkImpl()
		{
		}

		public ImageLinkImpl(User publisher, ImageFile file)
		{
			Publisher = publisher;
			File = file;
			_tags = new List<Tag>();
			DateCreate = DateTime.Now;
		}

		public ImageLinkImpl(User publisher, ImageFile file, IEnumerable<Tag> tags)
			:this(publisher, file)
		{
			foreach (var tag in tags)
			{
				_tags.Add(tag);
			}
		}

		public User Publisher { get; protected set; }

		public ImageFile File { get; protected set; }

		public DateTime DateCreate { get; protected set; }

		public IEnumerable<Tag> Tags { get { return _tags; } }

		public long Votes
		{
			get { return _repository.VoteCount(this); }
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}
	}
}