using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GulinSerge.PhotoLenta.Web.Model.Requests;
using GulinSerge.PhotoLenta.Web.Model.Responses;

namespace GulinSerge.PhotoLenta.Web.Model.Services
{
	/// <summary>
	/// Фасад аутентификации
	/// </summary>
	public interface WebAuthentification
	{
		/// <summary>
		/// Зарегистрировать пользователя
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		UserRegisterResponse RegisterUser(UserRegisterRequest request);

		/// <summary>
		/// Выполнить аутентификацию локально. TODO: Аутентификация через ВК API, Google API и т.д.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		UserLocalLoginResponse LocalAuthentificate(UserLocalLoginRequest request);
	}
}
