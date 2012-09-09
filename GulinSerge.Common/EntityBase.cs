using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GulinSerge.Common
{
	public abstract class EntityBase
	{
		protected EntityBase(){}
		public virtual long Id { get; protected set; }
	}

	/// <summary>
	/// Дескриптор бизнес-сущности
	/// </summary>
	public interface Entity
	{
		
	}
}
