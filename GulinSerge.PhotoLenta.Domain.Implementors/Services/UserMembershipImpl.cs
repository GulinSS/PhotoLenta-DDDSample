using System;
using GulinSerge.Common;
using GulinSerge.PhotoLenta.Domain.Entities;
using GulinSerge.PhotoLenta.Domain.Implementors.Entities;
using GulinSerge.PhotoLenta.Domain.Repositories;
using GulinSerge.PhotoLenta.Domain.Services;

namespace GulinSerge.PhotoLenta.Domain.Implementors.Services
{
	public class UserMembershipImpl : UserMembership
	{
		private readonly UserRepository _repository;

		public UserMembershipImpl(UserRepository repository)
		{
			_repository = repository;
		}

		public User Authentificate(IdentityCard card)
		{
			if (!CheckExist(card))
				throw new ObjectNotFoundException();

			return _repository.GetByIC(card);
		}

		public User Register(IdentityCard card)
		{
			if (CheckExist(card))
				throw new CommonException();

			IdentityCardLocal local = card as IdentityCardLocal;
			if (local == null)
				throw new ArgumentOutOfRangeException();

			//TODO: сгенерировать URL
			User user = new UserImpl(local.EMail, local);
			_repository.Put(user);
			return user;
		}

		private bool CheckExist(IdentityCard card)
		{
			return _repository.GetByIC(card) != null;
		}
	}


}