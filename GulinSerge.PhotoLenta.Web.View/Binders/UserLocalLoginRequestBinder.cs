using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.View.Extensions;

namespace GulinSerge.PhotoLenta.Web.View.Binders
{
	[ModelBinderType(typeof(UserLocalLoginRequest))]
	public class UserLocalLoginRequestBinder : IModelBinder
	{
		private const string EMAIL = "email";
		private const string PASSWORD = "password";

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			//TODO: проверка почты на валидность
			return new UserLocalLoginRequest(bindingContext.Get<string>(EMAIL), bindingContext.Get<string>(PASSWORD));
		}
	}
}