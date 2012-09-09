using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class UserVoteImpl :EntityBase, UserVote
	{
		protected UserVoteImpl()
		{
		}

		public UserVoteImpl(User user, ImageLink imageLink)
		{
			User = user;
			ImageLink = imageLink;
		}

		public User User { get; protected set; }

		public ImageLink ImageLink { get; protected set; }
	}


}