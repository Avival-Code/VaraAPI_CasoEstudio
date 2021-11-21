using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraAPI_CasoEstudio.Models
{
	public class Varamiento
	{
		public string uuid { get; set; }
		public bool finalizado { get; set; }
		public string nombreInformante { get; set; }
		public string telefonoInformante { get; set; }
		public string direccionInformante { get; set; }
		public string ordenAnimal { get; set; }
		public string condicionAnimal { get; set; }
		public int numeroAnimales { get; set; }
		public string observaciones { get; set; }
		public bool facilAcceso { get; set; }
		public bool acantilado { get; set; }
		public string sustrato { get; set; }
		public string primeraVezVisto { get; set; }
		public string fechaAvistamiento { get; set; }
		public string pais { get; set; }
		public string estado { get; set; }
		public string ciudad { get; set; }
		public string localidad { get; set; }
		public string informacionAdicionalUbicacion { get; set; }
		public string latitud { get; set; }
		public string longitud { get; set; }

		public Varamiento()
		{
			uuid = "";
			finalizado = false;
			nombreInformante = "";
			telefonoInformante = "";
			direccionInformante = "";
			ordenAnimal = "";
			condicionAnimal = "";
			numeroAnimales = 0;
			observaciones = "";
			facilAcceso = false;
			acantilado = false;
			sustrato = "";
			primeraVezVisto = "";
			fechaAvistamiento = "";
			pais = "";
			estado = "";
			ciudad = "";
			localidad = "";
			informacionAdicionalUbicacion = "";
			latitud = "";
			longitud = "";
		}

		public Varamiento( Varamiento original )
		{
			uuid = original.uuid;
			finalizado = original.finalizado;
			nombreInformante = original.nombreInformante;
			telefonoInformante = original.telefonoInformante;
			direccionInformante = original.direccionInformante;
			ordenAnimal = original.ordenAnimal;
			condicionAnimal = original.condicionAnimal;
			numeroAnimales = original.numeroAnimales;
			observaciones = original.observaciones;
			facilAcceso = original.facilAcceso;
			acantilado = original.acantilado;
			sustrato = original.sustrato;
			primeraVezVisto = original.primeraVezVisto;
			fechaAvistamiento = original.fechaAvistamiento;
			pais = original.pais;
			estado = original.estado;
			ciudad = original.ciudad;
			localidad = original.localidad;
			informacionAdicionalUbicacion = original.informacionAdicionalUbicacion;
			latitud = original.latitud;
			longitud = original.longitud;
		}

		public Varamiento( string uuidIn, bool finalizadoIn, string nombreInformanteIn, string telefonoInformanteIn, string direccionInformanteIn,
						   string ordenAnimalIn, string condicionAnimalIn, int numeroAnimalesIn, string observacionesIn, bool facilAccesoIn,
						   bool acantiladoIn, string sustratoIn, string primeraVezVistoIn, string fechaAvistamientoIn, string paisIn,
						   string estadoIn, string ciudadIn, string localidadIn, string informacionAdicionalUbicacionIn, string latitudIn,
						   string longitudIn)
		{
			uuid = uuidIn;
			finalizado = finalizadoIn;
			nombreInformante = nombreInformanteIn;
			telefonoInformante = telefonoInformanteIn;
			direccionInformante = direccionInformanteIn;
			ordenAnimal = ordenAnimalIn;
			condicionAnimal = condicionAnimalIn;
			numeroAnimales = numeroAnimalesIn;
			observaciones = observacionesIn;
			facilAcceso = facilAccesoIn;
			acantilado = acantiladoIn;
			sustrato = sustratoIn;
			primeraVezVisto = primeraVezVistoIn;
			fechaAvistamiento = fechaAvistamientoIn;
			pais = paisIn;
			estado = estadoIn;
			ciudad = ciudadIn;
			localidad = localidadIn;
			informacionAdicionalUbicacion = informacionAdicionalUbicacionIn;
			latitud = latitudIn;
			longitud = longitudIn;
		}
	}
}
