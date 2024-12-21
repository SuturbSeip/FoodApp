using FoodApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FoodApp.Services
{
    public interface INavigationService
    {
        ViewModel.ViewModel CurrentView { get; } 
        void NavigateTo<T>() where T : ViewModel.ViewModel;
    }
}
