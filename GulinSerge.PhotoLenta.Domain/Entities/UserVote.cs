using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface UserVote : Entity
	{
		User User { get; }
		ImageLink ImageLink { get; }
	}
}