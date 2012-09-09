using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace GulinSerge.Common.NhibernateAdditions
{
	public class UnitOfWorkImplNHibernate : UnitOfWork
	{
		private readonly ISessionFactory sessionFactory;
		private readonly ITransaction transaction;

		public UnitOfWorkImplNHibernate(ISessionFactory sessionFactory)
		{
			this.sessionFactory = sessionFactory;
			Session = this.sessionFactory.OpenSession();
			transaction = Session.BeginTransaction();
		}

		public ISession Session { get; private set; }

		public void Dispose()
		{
			Session.Close();
			Session = null;
		}

		public void Rollback()
		{
			if (transaction.IsActive)
				transaction.Rollback();
		}

		public void Commit()
		{
			if (transaction.IsActive)
				transaction.Commit();
		}
	}
}
