using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class IngredientCategory
    {
        public int Id { get; set; }
        public string Name { get; set;}

        public ICollection<Ingredient> Ingredients { get; set; }

        public IngredientCategory() { }

        public IngredientCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
