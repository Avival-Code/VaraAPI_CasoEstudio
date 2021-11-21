using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;

namespace VaraAPI_CasoEstudio.APIRequests
{
	public class TareasRequests
	{
		private string baseURL = "http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com";

		public TareasRequests()
		{
			ApiHelper.InitializeClient();
		}

		public async Task< LoginResponseData > RealizarLogin(string correo, string contrasenia )
		{
			try
			{
				var json = JsonConvert.SerializeObject( new LoginRequestData( correo, contrasenia ) );
				var data = new StringContent(json, Encoding.UTF8, "application/json");
				string loginURL = baseURL + "/auth/token";
				using( HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync( loginURL, data ) )
				{
					if( response.IsSuccessStatusCode )
					{
						LoginResponseData respuesta = await response.Content.ReadAsAsync< LoginResponseData >();
						return respuesta;
					}
					else
					{
						return null;
					}
				}
			}
			catch( Exception )
			{
				return null;
			}
		}

		public async Task< ObservableCollection< Varamiento > > RecuperarVaramientosUsuario( int claveUsuario, string token )
		{
			try
			{
				string requestURL = baseURL + "/yo/varamientos";
				ApiHelper.ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", token );
				using( HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync( requestURL ) )
				{
					if( response.IsSuccessStatusCode )
					{
						ObservableCollection< Varamiento > varamientos = await response.Content.ReadAsAsync< ObservableCollection< Varamiento > >();
						return varamientos;
					}
					else
					{
						return null;
					}
				}
			}
			catch( Exception )
			{
				return null;
			}
		}

		public async Task< Varamiento > EliminarVaramiento( string varamientoUuid, string token )
		{
			try
			{
				string requestURL = baseURL + "/yo/varamientos/" + varamientoUuid;
				ApiHelper.ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", token );
				using( HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync( requestURL ) )
				{
					if( response.IsSuccessStatusCode )
					{
						Varamiento respuesta = await response.Content.ReadAsAsync< Varamiento >();
						return respuesta;
					}
					else
					{
						return null;
					}
				}
			}
			catch( Exception )
			{
				return null;
			}
		}

		public async Task< Varamiento > ActualizarVaramiento( int claveUsuario, string token, Varamiento varamiento )
		{
			try
			{
				string requestURL = baseURL + "/yo/varamientos/" + varamiento.uuid;
				var json = JsonConvert.SerializeObject( varamiento );
				var data = new StringContent( json, Encoding.UTF8, "application/json" );
				ApiHelper.ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", token );
				using( HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync( requestURL, data ) )
				{
					if( response.IsSuccessStatusCode )
					{
						Varamiento respuesta = await response.Content.ReadAsAsync< Varamiento >();
						return respuesta;
					}
					else
					{
						return null;
					}
				}
			}
			catch( Exception )
			{
				return null;
			}
		}
	}
}
