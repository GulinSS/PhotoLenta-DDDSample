using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using GulinSerge.Common;

namespace GulinSerge.PhotoLenta.Web.View.Impl
{
	public class UserContainerImpl : UserContainer
	{
		public IPrincipal User
		{
			get { return HttpContext.Current.User; }
		}
	}
}