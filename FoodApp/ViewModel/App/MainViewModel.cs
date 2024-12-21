using FoodApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public class MainViewModel : ViewModel
    {
        public INavigationService _navigation;

        public INavigationService Navigation
        {
            get { return _navigation; }
            set
            {
                _navigation = value;
                OnPropertyChanged(nameof(Navigation));

            }
        }


        public RelayCommand NavigateToRecipesCommand { get; set; }
        public RelayCommand NavigateToAddRecipeCommand { get; set; }
        public RelayCommand NavigateToShoppingListCommand { get; set; }
        public RelayCommand NavigateToMealPlannerCommand { get; set; }
        public RelayCommand NavigateToMenusCommand { get; set; }
        public RelayCommand NavigateToIngredientsListCommand { get; set; }

        //Temp, delete later
        public RelayCommand NavigateToRecipeCommand { get; set; }
        //

        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;
            NavigateToRecipesCommand = new RelayCommand(o => { Navigation.NavigateTo<RecipesViewModel>(); }, o => true); 
            NavigateToAddRecipeCommand = new RelayCommand(o => { Navigation.NavigateTo<AddRecipeViewModel>(); }, o => true);
            NavigateToShoppingListCommand = new RelayCommand(o => { Navigation.NavigateTo<ShoppingListViewModel>(); }, o => true);
            NavigateToMealPlannerCommand = new RelayCommand(o => { Navigation.NavigateTo<MealPlannerViewModel>(); }, o => true);
            NavigateToMenusCommand = new RelayCommand(o => { Navigation.NavigateTo<MenusViewModel>(); }, o => true);
            //Temo, delete later.
            NavigateToRecipeCommand = new RelayCommand(o => { Navigation.NavigateTo<RecipeViewModel>(); }, o => true);
            NavigateToIngredientsListCommand = new RelayCommand(o => { Navigation.NavigateTo<IngredientsListViewModel>(); }, o => true);  
            //
        }
    }
}
