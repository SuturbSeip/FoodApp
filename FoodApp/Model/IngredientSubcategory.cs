using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class IngredientSubcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public IngredientCategory Category { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

        public IngredientSubcategory() { }
        public IngredientSubcategory(int id, string name, int categoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
        }
    }
}
