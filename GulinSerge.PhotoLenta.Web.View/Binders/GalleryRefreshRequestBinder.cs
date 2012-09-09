﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using GulinSerge.PhotoLenta.Web.Model.Requests;

namespace GulinSerge.PhotoLenta.Web.View.Binders
{
	[ModelBinderType(typeof(GalleryRefreshRequest))]
	public class GalleryRefreshRequestBinder : IModelBinder
	{
		#region IModelBinder Members

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}