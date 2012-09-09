namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// Запрос на аутентификацию
	/// </summary>
	public class UserLocalLoginRequest
	{
		public string Email { get; private set; }
		public string Password { get; private set; }

		public UserLocalLoginRequest(string email, string password)
		{
			Email = email;
			Password = password;
		}
	}
}