using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.Stores;
using VaraAPI_CasoEstudio.Services;
using VaraAPI_CasoEstudio.ViewModels;

namespace VaraAPI_CasoEstudio.Utilities
{
	class NavigationServiceCreator
	{
		private static NavigationServiceCreator creator;
		private NavigationStore navigationStore;
		public NavigationStore NavigationStore
		{
			get { return navigationStore; }
			set { navigationStore = value; }
		}


		private NavigationServiceCreator()
		{
			navigationStore = null;
		}

		public static NavigationServiceCreator GetInstance()
		{
			if (creator == null)
			{
				creator = new NavigationServiceCreator();
			}
			return creator;
		}

		public INavigationService< RegistrarVaramientoViewModel > CreateRegistrarVaramientoNavigationService()
		{
			return new LayoutNavigationService< RegistrarVaramientoViewModel >(
				navigationStore,
				() => new RegistrarVaramientoViewModel(), CreateNavigationBarViewModel);
		}

		private NavigationBarViewModel CreateNavigationBarViewModel()
		{
			return new NavigationBarViewModel();
		}
	}
}