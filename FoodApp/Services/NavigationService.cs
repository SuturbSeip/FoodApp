using FoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Services
{
    public class NavigationService : ViewModelBase, INavigationService
    {
        public ViewModel.ViewModel _currentView;
        private Func<Type, ViewModel.ViewModel> _viewModelFactory;

        public ViewModel.ViewModel CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged((nameof(CurrentView)));
            }
        }

        public NavigationService(Func<Type, ViewModel.ViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
            NavigateTo<RecipesViewModel>();
        }

        public void NavigateTo<TViewModel>() where TViewModel : ViewModel.ViewModel
        {
            ViewModel.ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModel;
        }
    }
}
