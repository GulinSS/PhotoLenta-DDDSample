namespace GulinSerge.PhotoLenta.Web.Model.Requests
{
	/// <summary>
	/// ������ �� �����������, ������ ������ �� �����
	/// </summary>
	public class UserRegisterRequest
	{
		public UserRegisterRequest(string eMail)
		{
			EMail = eMail;
		}

		/// <summary>
		/// ����� ��� �����
		/// </summary>
		public string EMail { get; private set; }
	}
}