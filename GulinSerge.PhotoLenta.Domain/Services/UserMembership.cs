using GulinSerge.PhotoLenta.Domain.Entities;

namespace GulinSerge.PhotoLenta.Domain.Services
{
	public interface UserMembership
	{
		User Authentificate(IdentityCard card);
		User Register(IdentityCard card);
	}
}