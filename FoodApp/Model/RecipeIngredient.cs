using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public float Quantity { get; set; }
        public Unit Unit { get; set; }

        public RecipeIngredient() { }

        public RecipeIngredient(int id, int ingredientId, int recipeId, float quantity, Unit unit) 
        {
            Id = id;
            IngredientId = ingredientId;
            RecipeId = recipeId;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
