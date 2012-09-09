using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;

namespace GulinSerge.PhotoLenta.Web.View.Binders
{
	[ModelBinderType(typeof(PhotoPublishRequest))]
	public class PhotoPublishRequestBinder : IModelBinder
	{
		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			throw new NotImplementedException();
		}
	}
}