using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Entities
{
	public class IdentityCardLocalImpl : EntityBase, IdentityCardLocal
	{
		protected IdentityCardLocalImpl()
		{
		}

		public IdentityCardLocalImpl(string eMail, string password)
		{
			EMail = eMail;
			Password = password;
		}

		public string EMail { get; protected set; }

		public string Password { get; protected set; }

		public object IdentityKey
		{
			get { return EMail; }
		}

		public bool VerifyCard(IdentityCard card)
		{
			IdentityCardLocal cardLocal = card as IdentityCardLocal;
			if (cardLocal == null)
				return false;

			return cardLocal.EMail == EMail && cardLocal.Password == Password;
		}
	}
}