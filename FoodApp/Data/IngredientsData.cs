using FoodApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Data
{ 
    public static class IngredientsData
    {
        public static List<IngredientCategory> GetIngredientCategories()
        {
            using (var context = new IngredientDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public static List<IngredientSubcategory> GetIngredientSubcategories()
        {
            using (var context = new IngredientDbContext())
            {
                return context.Subcategories.ToList();
            }
        }

        public static List<Ingredient> GetAllIngredients()
        {
            using (var context = new IngredientDbContext())
            {
                return context.Ingredients.ToList();
            }
        }

        public static List<IngredientSubcategory> GetIngredientSubcategoriesByCategoryId(int categoryId)
        {
            using (var context = new IngredientDbContext())
            {
                return context.Subcategories.Where(s => s.CategoryId == categoryId).ToList();
            }
        }

        public static List<Ingredient> GetIngredientsByCategoryId(int categoryId)
        {
            using (var context = new IngredientDbContext())
            {
                return context.Ingredients.Where(c => c.CategoryId == categoryId).ToList();
            }
        }

        public static List<Ingredient> GetIngredientsBySubcategoryId(int subcategoryId)
        {
            using (var context = new IngredientDbContext())
            {
                return context.Ingredients.Where(c => c.SubcategoryId == subcategoryId).ToList();
            }
        }

        public static string GetIngredientSubcategoryNameById(int? subcategoryId)
        {
            if (subcategoryId != null && subcategoryId > 0)
            {
                using (var context = new IngredientDbContext())
                {
                    return context.Subcategories.Where(s => s.Id == subcategoryId).First().Name;
                }
            }
            return "";
        }

        public static string GetIngredientCategoryNameById(int categoryId)
        {
            using (var context = new IngredientDbContext())
            {
                return context.Categories.Where(s => s.Id == categoryId)
                    .First().Name;
            }
        }

        public static void AddIngredient(Ingredient ingredient)
        {
            if (GetAllIngredients().Any(i => i.Name == ingredient.Name))
                return;
            using (var context = new IngredientDbContext())
            {
                context.Ingredients.Add(ingredient);
                context.SaveChanges();
            }
        }

        public static Recipe GetRecipeById(int recipeId)
        {
            using (var context = new IngredientDbContext())
            {
                //var recipe = context.Recipes.FirstOrDefault(i => i.Id == recipeId);

                //var recipeIngredients = context.RecipeIngredients.Where(recipe => recipe.Id == recipeId);
                //foreach (var ingredient in recipeIngredients)
                //{
                //    ingredient.Ingredient = context.Ingredients.FirstOrDefault(i => i.Id == ingredient.IngredientId);
                //}
                //recipe.RecipeIngredients = recipeIngredients.ToList();
                var recipe = context.Recipes
                   .Include(r => r.RecipeIngredients)
                   .ThenInclude(ri => ri.Ingredient)
                   .FirstOrDefault(r => r.Id == recipeId);

                return recipe;
            }
        }
    }
}
