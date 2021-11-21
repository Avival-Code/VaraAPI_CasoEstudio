using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraAPI_CasoEstudio.Models
{
	public class LoginRequestData
	{
		public string correoElectronico { get; set; }
		public string contrasenia { get; set; }

		public LoginRequestData()
		{
			correoElectronico = "";
			contrasenia = "";
		}

		public LoginRequestData( LoginRequestData original )
		{
			correoElectronico = original.correoElectronico;
			contrasenia = original.contrasenia;
		}

		public LoginRequestData( string correoIn, string contrasenaIn )
		{
			correoElectronico = correoIn;
			contrasenia = contrasenaIn;
		}
	}
}