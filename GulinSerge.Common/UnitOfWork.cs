using System;

namespace GulinSerge.Common
{
	public interface UnitOfWork : IDisposable
	{
		void Rollback();
		void Commit();
	}
}