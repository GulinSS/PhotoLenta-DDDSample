using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;

namespace GulinSerge.PhotoLenta.Web.Model.Responses
{
	public class UserRegisterResponse
	{
		/// <summary>
		/// Статус аутентификации
		/// </summary>
		public LoginInfo LoginStatus { get; private set; }
	}
}
