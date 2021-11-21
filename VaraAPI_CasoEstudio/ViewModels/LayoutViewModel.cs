using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraAPI_CasoEstudio.ViewModels
{
	public class LayoutViewModel : ViewModel
	{
		public NavigationBarViewModel NavigationBarViewModel { get; }
		public ViewModel ContentViewModel { get; }

		public LayoutViewModel( NavigationBarViewModel navigationBarViewModel, ViewModel contentViewModel )
		{
			NavigationBarViewModel = navigationBarViewModel;
			ContentViewModel = contentViewModel;
		}
	}
}