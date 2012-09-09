using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.Entities;
using GulinSerge.PhotoLenta.Web.Model.ViewModels.Pages;

namespace GulinSerge.PhotoLenta.Web.Model.Services
{
	public interface WebPhoto
	{
		PhotoFile GetPhoto(PhotoLink link);

		PhotoFile GetThumbnail(PhotoLink link);
	}
}
