using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.ViewModels;

namespace VaraAPI_CasoEstudio.Services
{
	public interface INavigationService< TViewModel >
		where TViewModel : ViewModel
	{
		void Navigate();
	}
}
