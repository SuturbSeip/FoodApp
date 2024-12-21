using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public class RecipeIngredientViewModel
    {
        private readonly RecipeIngredient _recipeIngredient;

        public IngredientViewModel IngredientViewModel { get; private set; }

        public float Quantity
        {
            get => _recipeIngredient.Quantity;
        }

        public Unit Unit
        {
            get => _recipeIngredient.Unit;
        }

        public RecipeIngredientViewModel(RecipeIngredient recipeIngredient)
        {
            _recipeIngredient = recipeIngredient;
            IngredientViewModel = new IngredientViewModel(recipeIngredient.Ingredient);
        }
    }
}
