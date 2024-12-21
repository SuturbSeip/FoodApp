using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set;} = new List<RecipeIngredient>();
        public string Instructions { get; set; }


        public Recipe() { }
        public Recipe(int id, string name, List<RecipeIngredient> recipeIngredients, string instructions)
        {
            Id = id;
            RecipeName = name;
            RecipeIngredients = recipeIngredients;
            Instructions = instructions;
        }
    }
}
