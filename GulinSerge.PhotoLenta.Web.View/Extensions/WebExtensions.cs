using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls;
using GulinSerge.PhotoLenta.Web.View.Exceptions;
using Newtonsoft.Json;

namespace GulinSerge.PhotoLenta.Web.View.Extensions
{
	public static class WebExtensions
	{
		/// <summary>
		/// Короткий вызов преобразования параметров
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="context"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static T Get<T>(this ModelBindingContext context, string name)
		{
			ValueProviderResult result = context.ValueProvider.GetValue(name);
			if (result == null)
				throw new WrongParametersException();

			return (T) result.ConvertTo(typeof (T));
		}

		/// <summary>
		/// Maybe monad
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TO"></typeparam>
		/// <param name="o"></param>
		/// <param name="f"></param>
		/// <returns></returns>
		public static TO Safe<T, TO>(this T o, Func<T, TO> f)
			where TO : class where T : class
		{
			if (o == null)
				return null;
			return f(o);
		}

		public static ActionResult ToJson(this object o)
		{
			string serialized = JsonConvert.SerializeObject(o, Formatting.Indented);
			
			return new ContentResult
			       	{
			       		Content = serialized,
			       		ContentType = "application/json",
			       		ContentEncoding = Encoding.UTF8
			       	};
		}
	}
}