﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaraAPI_CasoEstudio.ViewModels;

namespace VaraAPI_CasoEstudio.Stores
{
	public class NavigationStore
	{
		public event Action CurrentViewModelChanged;
		private ViewModel _currentViewModel;

		public ViewModel CurrentViewModel
		{
			get => _currentViewModel;
			set
			{
				_currentViewModel = value;
				OnCurrentViewModelChanged();
			}
		}

		private void OnCurrentViewModelChanged()
		{
			CurrentViewModelChanged?.Invoke();
		}
	}
}