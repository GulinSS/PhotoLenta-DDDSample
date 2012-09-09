namespace GulinSerge.PhotoLenta.Domain.Entities
{
	public interface IdentityCardLocal: IdentityCard
	{
		string EMail { get; }
		string Password { get; }
	}
}