using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface Tag : Entity
	{
		string DisplayName { get; }
		long Weight { get; }
		void IncrementWeight();
	}
}