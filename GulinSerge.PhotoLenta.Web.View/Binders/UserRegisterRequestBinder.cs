using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.View.Exceptions;
using GulinSerge.PhotoLenta.Web.View.Extensions;

namespace GulinSerge.PhotoLenta.Web.View.Binders
{
	[ModelBinderType(typeof(UserRegisterRequest))]
	public class UserRegisterRequestBinder : IModelBinder
	{
		private const string EMAIL = "email";

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			//TODO: проверка почты на валидность
			return new UserRegisterRequest(bindingContext.Get<string>(EMAIL));
		}
	}
}