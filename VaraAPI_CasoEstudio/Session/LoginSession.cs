using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraAPI_CasoEstudio.Session
{
	class LoginSession
	{
		private static LoginSession loginInstance;
		public string AccessToken { get; set; }
		public string uuid { get; set; }

		private LoginSession()
		{
			AccessToken = "";
		}

		public static LoginSession GetInstance()
		{
			if( loginInstance == null )
			{
				loginInstance = new LoginSession();
			}
			return loginInstance;
		}

		public bool IsLoggedIn
		{
			get { return AccessToken != ""; }
		}

		public void Logout()
		{
			if( IsLoggedIn )
			{
				AccessToken = "";
				uuid = "";
			}
		}
	}
}
