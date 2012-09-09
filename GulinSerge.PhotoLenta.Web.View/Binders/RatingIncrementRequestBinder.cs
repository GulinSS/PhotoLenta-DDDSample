using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.View.Extensions;

namespace GulinSerge.PhotoLenta.Web.View.Binders
{
	[ModelBinderType(typeof(RatingIncrementRequest))]
	public class RatingIncrementRequestBinder : IModelBinder
	{
		private const string PHOTOID = "photoid";

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			return new RatingIncrementRequest(new PhotoLink(bindingContext.Get<long>(PHOTOID)));
		}
	}
}