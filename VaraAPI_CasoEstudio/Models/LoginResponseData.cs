using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraAPI_CasoEstudio.Models
{
	public class LoginResponseData
	{
		public string token { get; set; }
		public string refreshToken { get; set; }
		public string uuid { get; set; }

		public LoginResponseData()
		{
			token = "";
			refreshToken = "";
			uuid = "";
		}

		public LoginResponseData( LoginResponseData original )
		{
			token = original.token;
			refreshToken = original.refreshToken;
			uuid = original.uuid;
		}

		public LoginResponseData( string tokenIn, string refreshTokenIn, string idIn )
		{
			token = tokenIn;
			refreshToken = refreshTokenIn;
			uuid = idIn;
		}
	}
}