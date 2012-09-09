using System;

namespace GulinSerge.PhotoLenta.Web.Model.ViewModels.Controls
{
	/// <summary>
	/// ����� ��� ����������� ������
	/// </summary>
	public class LoginInfo
	{
		private readonly string _login = string.Empty;

		/// <summary>
		/// ������������ �� ���������.
		/// </summary>
		public LoginInfo()
		{
			IsLogin = false;
		}

		public LoginInfo(string account)
		{
			IsLogin = true;
			_login = account;
		}

		public bool IsLogin { get; private set; }

		public string Login
		{
			get
			{
				if (string.IsNullOrEmpty(_login))
					throw new NotSupportedException();

				return _login;
			}
		}
	}
}