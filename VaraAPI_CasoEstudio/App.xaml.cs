using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VaraAPI_CasoEstudio.Stores;
using VaraAPI_CasoEstudio.Services;
using VaraAPI_CasoEstudio.Utilities;
using VaraAPI_CasoEstudio.ViewModels;

namespace VaraAPI_CasoEstudio
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly NavigationStore navigationStore;

		public App()
		{
			navigationStore = new NavigationStore();
			NavigationServiceCreator.GetInstance().NavigationStore = navigationStore;
		}

		protected override void OnStartup( StartupEventArgs startUpEvents )
		{
			INavigationService< RegistrarVaramientoViewModel > RegistrarVaramientoNavigationService = NavigationServiceCreator.GetInstance().CreateRegistrarVaramientoNavigationService();
			RegistrarVaramientoNavigationService.Navigate();

			MainWindow = new MainWindow()
			{
				DataContext = new MainViewModel( navigationStore )
			};
			MainWindow.Show();

			base.OnStartup( startUpEvents );
		}
	}
}
