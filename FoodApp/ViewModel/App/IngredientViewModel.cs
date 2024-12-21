using FoodApp.Data;
using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public class IngredientViewModel : ViewModelBase
    {
        private Ingredient _ingredient;


        public int Id { 
            get
            {
                return _ingredient.Id;
            } 
        }
        public string Name { 
            get
            {
                return _ingredient.Name;
            }
        }
        
        public string CategoryName
        {
            get { return IngredientsData.GetIngredientCategoryNameById(_ingredient.CategoryId); }
        }

        public string SubcategoryName
        {
            get { return IngredientsData.GetIngredientSubcategoryNameById(_ingredient.SubcategoryId); }
        }

        public IngredientViewModel(Ingredient ingredient)
        {
            _ingredient = ingredient;
        }
    }
}
