using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface IdentityCard : Entity
	{
		/// <summary>
		/// TODO: �������� � ���������
		/// </summary>
		object IdentityKey { get; }

		bool VerifyCard(IdentityCard card);
	}
}