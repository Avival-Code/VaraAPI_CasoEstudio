using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.Stores;

namespace VaraAPI_CasoEstudio.ViewModels
{
	public class MainViewModel : ViewModel
	{
		private readonly NavigationStore _navigationStore;

		public ViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

		public MainViewModel( NavigationStore navigationStore )
		{
			_navigationStore = navigationStore;
			_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
		}

		private void OnCurrentViewModelChanged()
		{
			OnPropertyChanged( nameof( CurrentViewModel ) );
		}
	}
}