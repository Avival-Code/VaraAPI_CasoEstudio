using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.APIRequests;

namespace VaraAPI_CasoEstudio.ViewModels
{
	public class RegistrarVaramientoViewModel : ViewModel
	{
		private TareasRequests requests;

		private bool finalizado = false;
		private string nombre;
		private string telefono;
		private string direccion;
		private string orden = "SIRENO";
		private string condicion = "VIVO";
		private int numero;
		private string observaciones;
		private bool facil;
		private bool acantilado;
		private string sustrato = "ARENA";
		private string primera = "AGUA";
		private string fecha;
		private string pais;
		private string estado;
		private string ciudad;
		private string localidad;
		private string informacion;
		private string latitud;
		private string longitud;

		public bool Finalizado 
		{ 
			get { return finalizado; }
			set { finalizado = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Observaciones
		{
			get { return observaciones; }
			set { observaciones = value; }
		}

		public bool Facil
		{
			get { return facil; }
			set 
			{ 
				facil = value;
				Console.WriteLine( facil );
			}
		}

		public bool Acantilado
		{
			get { return acantilado; }
			set 
			{ 
				acantilado = value;
				Console.WriteLine( acantilado );
			}
		}

		public string Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		public string Pais
		{
			get { return pais; }
			set { pais = value; }
		}

		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		public string Ciudad
		{
			get { return ciudad; }
			set { ciudad = value; }
		}

		public string Localidad
		{
			get { return localidad; }
			set { localidad = value; }
		}

		public string Informacion
		{
			get { return informacion; }
			set { informacion = value; }
		}

		public string Latitud
		{
			get { return latitud; }
			set { latitud = value; }
		}

		public string Longitud
		{
			get { return longitud; }
			set { longitud = value; }
		}

		public RegistrarVaramientoViewModel()
		{
			requests = new TareasRequests();
		}
	}
}
