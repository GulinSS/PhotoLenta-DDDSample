using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Responses;
using GulinSerge.PhotoLenta.Web.Model.Services;

namespace GulinSerge.PhotoLenta.Web.Stubs
{
	public class WebAuthentificationImpl : WebAuthentification
	{
		public UserRegisterResponse RegisterUser(UserRegisterRequest request)
		{
			throw new NotImplementedException();
		}

		public UserLocalLoginResponse LocalAuthentificate(UserLocalLoginRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
