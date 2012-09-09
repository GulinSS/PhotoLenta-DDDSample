namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на регистрацию, пароль придет по почте
	/// </summary>
	public class UserRegisterRequest
	{
		public UserRegisterRequest(string eMail)
		{
			EMail = eMail;
		}

		/// <summary>
		/// Почта как логин
		/// </summary>
		public string EMail { get; private set; }
	}
}