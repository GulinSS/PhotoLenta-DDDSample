using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace GulinSerge.Common
{
	/// <summary>
	/// Контейнер сессии пользователя
	/// </summary>
	public interface UserContainer
	{
		IPrincipal User { get; }
	}
}
