using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.ViewModels;
using VaraAPI_CasoEstudio.Stores;

namespace VaraAPI_CasoEstudio.Services
{
	public class LayoutNavigationService< TViewModel > : INavigationService< TViewModel >
		where TViewModel : ViewModel
	{
		private readonly NavigationStore navigationStore;
		private readonly Func< TViewModel > createViewModel;
		private readonly Func< NavigationBarViewModel > createNavigationBarViewModel;

		public LayoutNavigationService( NavigationStore navigationStoreIn,
			Func< TViewModel > createViewModelFunction,
			Func< NavigationBarViewModel > createNavigationBarViewModelFunction )
		{
			navigationStore = navigationStoreIn;
			createViewModel = createViewModelFunction;
			createNavigationBarViewModel = createNavigationBarViewModelFunction;
		}

		public void Navigate()
		{
			navigationStore.CurrentViewModel = new LayoutViewModel( createNavigationBarViewModel(), createViewModel() );
		}
	}
}
