﻿namespace Launcher
{
	public class LoginToken
	{
		public string email;
		public string password;
		public bool toggle;
		public long timestamp;

		public LoginToken(string email, string password)
		{
			this.email = email;
			this.password = password;
			toggle = true;
			timestamp = 0;
		}
	}
}
