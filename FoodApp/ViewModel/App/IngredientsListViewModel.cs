using FoodApp.Data;
using FoodApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace FoodApp.ViewModel
{
    public class IngredientsListViewModel : ViewModel
    {
        public ObservableCollection<IngredientViewModel> Ingredients { get; set; } = new ObservableCollection<IngredientViewModel>();
        public ObservableCollection<IngredientCategory> IngredientCategories { get; set; } = new ObservableCollection<IngredientCategory>(IngredientsData.GetIngredientCategories());
        public ObservableCollection<IngredientSubcategory> _ingredientSubcategories;
        public ObservableCollection<IngredientSubcategory> IngredientSubcategories 
        {
            get
            {
                return _ingredientSubcategories;
            }
            set
            {
                _ingredientSubcategories = value;
                OnPropertyChanged(nameof(IngredientSubcategories));

            }
        }


        private int _selectedCategoryId;
        public int SelectedCategoryId
        {
            get { return _selectedCategoryId; }
            set
            {
                _selectedCategoryId = value;
                OnPropertyChanged(nameof(SelectedCategoryId));
                UpdateIngredientSubcategoryList();
            }
        }

        private int _selectedSubcategoryId;
        public int SelectedSubcategoryId
        {
            get => _selectedSubcategoryId;
            set
            {
                _selectedSubcategoryId = value;
                OnPropertyChanged(nameof(SelectedSubcategoryId));
            }
        }

        private string _newIngredientName;
        public string NewIngredientName
        {
            get => _newIngredientName;
            set
            {
                _newIngredientName = value;
                { OnPropertyChanged(nameof(NewIngredientName)); }
            }
        }

        private void UpdateIngredientSubcategoryList()
        {
            IngredientSubcategories = new ObservableCollection<IngredientSubcategory>(IngredientsData.GetIngredientSubcategoriesByCategoryId(_selectedCategoryId));

        }

        public IngredientsListViewModel()
        {
            _newIngredientName = "";
            List<Ingredient> database = IngredientsData.GetAllIngredients();

            foreach (var ingredient in database)
            {
                Ingredients.Add(new IngredientViewModel(ingredient));
            }
        }

        private ICommand addIngredientToDatabase;

        public ICommand AddIngredientToDatabase
        {
            get
            {
                if (addIngredientToDatabase == null)
                    addIngredientToDatabase = new RelayCommand(o =>
                    {
                        Ingredient ingredient = new Ingredient(Ingredients.Count + 1, _newIngredientName, _selectedCategoryId, _selectedSubcategoryId);
                        IngredientsData.AddIngredient(ingredient);
                    },
                    o => true);
                return addIngredientToDatabase;
            }
        }
    }
}
