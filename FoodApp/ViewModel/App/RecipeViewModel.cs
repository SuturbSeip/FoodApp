using FoodApp.Data;
using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public class RecipeViewModel : ViewModel
    {
        public Recipe _recipe;

        public string RecipeName { get => _recipe.RecipeName; }
        public ObservableCollection<RecipeIngredientViewModel> RecipeIngredients { get; } = new ObservableCollection<RecipeIngredientViewModel>(); 
        public string Description { get => _recipe.Instructions; }

        public RecipeViewModel()
        {
            _recipe = IngredientsData.GetRecipeById(1);
            foreach (var recipeingredient in _recipe.RecipeIngredients)
            {
                RecipeIngredients.Add(new RecipeIngredientViewModel(recipeingredient));
            }
        }
    }
}
