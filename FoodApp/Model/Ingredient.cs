using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int? SubcategoryId { get; set; }

        public IngredientCategory Category { get; set; }
        public IngredientSubcategory Subcategory { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();


        public Ingredient() { }

        public Ingredient( int id, string name, int categoryId) 
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            SubcategoryId = null;
        }

        public Ingredient( int id, string name, int categoryId, int subcategoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            SubcategoryId = subcategoryId;
        }

    }
}
