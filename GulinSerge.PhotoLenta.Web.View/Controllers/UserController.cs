using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Services;
using GulinSerge.PhotoLenta.Web.View.Extensions;

namespace GulinSerge.PhotoLenta.Web.View.Controllers
{
	public class UserController : Controller
	{
		private readonly WebAuthentification _authentification;

		public UserController(WebAuthentification authentification)
		{
			_authentification = authentification;
		}

		public ActionResult Register(UserRegisterRequest request)
		{
			return _authentification.RegisterUser(request).ToJson();
		}
	}
}