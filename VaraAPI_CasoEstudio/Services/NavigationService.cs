using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.ViewModels;
using VaraAPI_CasoEstudio.Stores;

namespace VaraAPI_CasoEstudio.Services
{
	public class NavigationService< TViewModel > : INavigationService< TViewModel >
		where TViewModel : ViewModel
	{
		private readonly NavigationStore navigationStore;
		private readonly Func< TViewModel > createViewModel;

		public NavigationService( NavigationStore navigationStoreIn, Func< TViewModel > createViewModelFunction )
		{
			navigationStore = navigationStoreIn;
			createViewModel = createViewModelFunction;
		}

		public void Navigate()
		{
			navigationStore.CurrentViewModel = createViewModel();
		}
	}
}