using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GulinSerge.PhotoLenta.Web.View.Controllers
{
	/// <summary>
	/// Отправка "статичных" страниц
	/// </summary>
	public class InfoController : Controller
	{
		public ActionResult AboutAvatar()
		{
			return View();
		}
	}
}