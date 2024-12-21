using Microsoft.EntityFrameworkCore;
using System;

namespace FoodApp.Model
{
    public class IngredientDbContext : DbContext
    {
        public string path = @"C:\Users\adria\source\repos\MyOwn\FoodApp\FoodApp\IngredientsDB.db";
        public DbSet<IngredientCategory> Categories { get; set; }
        public DbSet<IngredientSubcategory> Subcategories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source ={path}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<RecipeIngredient>()
                .Property(ri => ri.Unit)
                .HasConversion(
                v => v.ToString(),
                v => (Unit)Enum.Parse(typeof(Unit), v));

            modelBuilder.Entity<IngredientCategory>().HasData(
                new IngredientCategory { Id = 1, Name = "Greengrocer's" },
                new IngredientCategory { Id = 2, Name = "Butchery" },
                new IngredientCategory { Id = 3, Name = "Bakery" },
                new IngredientCategory { Id = 4, Name = "Dairy & Eggs" },
                new IngredientCategory { Id = 5, Name = "Pantry" },
                new IngredientCategory { Id = 6, Name = "Frozen Foods" },
                new IngredientCategory { Id = 7, Name = "Home & Cleaning" }
                );

            modelBuilder.Entity<IngredientSubcategory>().HasData(
                // Subcattgories for Greengrocer's
                new IngredientSubcategory { Id = 1, Name = "Vegetables", CategoryId = 1 },
                new IngredientSubcategory { Id = 2, Name = "Fruits", CategoryId = 1 },
                new IngredientSubcategory { Id = 3, Name = "Herbs", CategoryId = 1 },
                // Subcategories for Butchery
                new IngredientSubcategory { Id = 4, Name = "Meats", CategoryId = 2 },
                new IngredientSubcategory { Id = 5, Name = "Deli Meats", CategoryId = 2 },
                new IngredientSubcategory { Id = 6, Name = "Seafoods", CategoryId = 2 },
                // Subcategoris for Bakery
                new IngredientSubcategory { Id = 7, Name = "Breads", CategoryId = 3 },
                new IngredientSubcategory { Id = 8, Name = "Cakes and Pastries", CategoryId = 3 },
                new IngredientSubcategory { Id = 9, Name = "Tortillas and Flatbreads", CategoryId = 3 },
                // Subcategories for Dairy & Eggs
                new IngredientSubcategory { Id = 10, Name = "Milks and Creams", CategoryId = 4 },
                new IngredientSubcategory { Id = 11, Name = "Yogurts and Kefirs", CategoryId = 4 },
                new IngredientSubcategory { Id = 12, Name = "Butters and Margarines", CategoryId = 4 },
                new IngredientSubcategory { Id = 13, Name = "Eggs", CategoryId = 4 },
                new IngredientSubcategory { Id = 14, Name = "Cheeses", CategoryId = 4 },
                // Subcategories for Pantry
                new IngredientSubcategory { Id = 15, Name = "Grains & Pastas", CategoryId = 5 },
                new IngredientSubcategory { Id = 16, Name = "Canned Goods", CategoryId = 5 },
                new IngredientSubcategory { Id = 17, Name = "Baking Suplies", CategoryId = 5 },
                new IngredientSubcategory { Id = 18, Name = "Spices", CategoryId = 5 },
                new IngredientSubcategory { Id = 19, Name = "Sauces and Condiments", CategoryId = 5 },
                new IngredientSubcategory { Id = 20, Name = "Snacks", CategoryId = 5 },
                new IngredientSubcategory { Id = 21, Name = "Preserved Foods", CategoryId = 5 },
                new IngredientSubcategory { Id = 22, Name = "Ready Meals", CategoryId = 5 },
                new IngredientSubcategory { Id = 31, Name = "Beverages", CategoryId = 5 },
                // Subcategories for Frozens
                new IngredientSubcategory { Id = 23, Name = "Frozen Vegetables", CategoryId = 6 },
                new IngredientSubcategory { Id = 24, Name = "Frozen Fruits", CategoryId = 6 },
                new IngredientSubcategory { Id = 25, Name = "Frozen Meats & Seafoods", CategoryId = 6 },
                new IngredientSubcategory { Id = 26, Name = "Frozen Ready Meals", CategoryId = 6 },
                new IngredientSubcategory { Id = 27, Name = "Frozen Desserts", CategoryId = 6 },
                // Subcategories for Home & Cleaning 
                new IngredientSubcategory { Id = 28, Name = "Cleaning Supplies", CategoryId = 7 },
                new IngredientSubcategory { Id = 29, Name = "Hygiene Products", CategoryId = 7 },
                new IngredientSubcategory { Id = 30, Name = "Other Accesories", CategoryId = 7 }
                );

            modelBuilder.Entity<Ingredient>().HasData(
                 // Basic ingredients for Greengrocer's
                 new Ingredient { Id = 1, Name = "carrot", CategoryId = 1, SubcategoryId = 1 },
                 new Ingredient { Id = 2, Name = "broccoli", CategoryId = 1, SubcategoryId = 1 },
                 new Ingredient { Id = 3, Name = "tomatoe", CategoryId = 1, SubcategoryId = 1 },

                 new Ingredient { Id = 4, Name = "apple", CategoryId = 1, SubcategoryId = 2 },
                 new Ingredient { Id = 5, Name = "banana", CategoryId = 1, SubcategoryId = 2 },
                 new Ingredient { Id = 6, Name = "orange", CategoryId = 1, SubcategoryId = 2 },

                 new Ingredient { Id = 7, Name = "parsley", CategoryId = 1, SubcategoryId = 3 },
                 new Ingredient { Id = 8, Name = "basil", CategoryId = 1, SubcategoryId = 3 },
                 new Ingredient { Id = 9, Name = "cilantro", CategoryId = 1, SubcategoryId = 3 },

                 // Basic ingredients for Butchery
                 new Ingredient { Id = 10, Name = "chicken breast", CategoryId = 2, SubcategoryId = 4 },
                 new Ingredient { Id = 11, Name = "roast beef", CategoryId = 2, SubcategoryId = 4 },
                 new Ingredient { Id = 12, Name = "pork chops", CategoryId = 2, SubcategoryId = 4 },

                 new Ingredient { Id = 13, Name = "ham", CategoryId = 2, SubcategoryId = 5 },
                 new Ingredient { Id = 14, Name = "salami", CategoryId = 2, SubcategoryId = 5 },
                 new Ingredient { Id = 15, Name = "bacon", CategoryId = 2, SubcategoryId = 5 },

                 new Ingredient { Id = 16, Name = "cod", CategoryId = 2, SubcategoryId = 6 },
                 new Ingredient { Id = 17, Name = "trout", CategoryId = 2, SubcategoryId = 6 },
                 new Ingredient { Id = 18, Name = "salmon fillet", CategoryId = 2, SubcategoryId = 6 },

                 // Basic ingredients for Bakery
                 new Ingredient { Id = 19, Name = "sourdough", CategoryId = 3, SubcategoryId = 7 },
                 new Ingredient { Id = 20, Name = "wholegrain", CategoryId = 3, SubcategoryId = 7 },
                 new Ingredient { Id = 21, Name = "baguette", CategoryId = 3, SubcategoryId = 7 },

                 new Ingredient { Id = 22, Name = "croissant", CategoryId = 3, SubcategoryId = 8 },
                 new Ingredient { Id = 23, Name = "muffin", CategoryId = 3, SubcategoryId = 8 },
                 new Ingredient { Id = 24, Name = "chocolate cake", CategoryId = 3, SubcategoryId = 8 },

                 new Ingredient { Id = 25, Name = "wheat tortilla", CategoryId = 3, SubcategoryId = 9 },
                 new Ingredient { Id = 26, Name = "pita", CategoryId = 3, SubcategoryId = 9 },
                 new Ingredient { Id = 27, Name = "naan", CategoryId = 3, SubcategoryId = 9 },

                 // Basic ingredients for Dairy & Eggs
                 new Ingredient { Id = 28, Name = "milk 3.2%", CategoryId = 4, SubcategoryId = 10 },
                 new Ingredient { Id = 29, Name = "cream 18%", CategoryId = 4, SubcategoryId = 10 },
                 new Ingredient { Id = 30, Name = "heavy cream 36%", CategoryId = 4, SubcategoryId = 10 },

                 new Ingredient { Id = 31, Name = "greek yogurt", CategoryId = 4, SubcategoryId = 11 },
                 new Ingredient { Id = 32, Name = "plain yogurt", CategoryId = 4, SubcategoryId = 11 },
                 new Ingredient { Id = 33, Name = "kefir", CategoryId = 4, SubcategoryId = 11 },

                 new Ingredient { Id = 34, Name = "butter", CategoryId = 4, SubcategoryId = 12 },
                 new Ingredient { Id = 35, Name = "salted butter", CategoryId = 4, SubcategoryId = 12 },
                 new Ingredient { Id = 36, Name = "margarine", CategoryId = 4, SubcategoryId = 12 },

                 new Ingredient { Id = 37, Name = "egg", CategoryId = 4, SubcategoryId = 13 },
                 new Ingredient { Id = 38, Name = "free-range egg", CategoryId = 4, SubcategoryId = 13 },
                 new Ingredient { Id = 39, Name = "organic egg", CategoryId = 4, SubcategoryId = 13 },

                 new Ingredient { Id = 40, Name = "cheddar", CategoryId = 4, SubcategoryId = 14 },
                 new Ingredient { Id = 41, Name = "mozarella", CategoryId = 4, SubcategoryId = 14 },
                 new Ingredient { Id = 42, Name = "feta", CategoryId = 4, SubcategoryId = 14 },

                 // Basic ingredients for Pantry
                 new Ingredient { Id = 43, Name = "spaghetti", CategoryId = 5, SubcategoryId = 15 },
                 new Ingredient { Id = 44, Name = "rice", CategoryId = 5, SubcategoryId = 15 },
                 new Ingredient { Id = 45, Name = "spelt groats", CategoryId = 5, SubcategoryId = 15 },

                 new Ingredient { Id = 46, Name = "canned tomatoes", CategoryId = 5, SubcategoryId = 16 },
                 new Ingredient { Id = 47, Name = "canned sweetcorn", CategoryId = 5, SubcategoryId = 16 },
                 new Ingredient { Id = 48, Name = "canned beans", CategoryId = 5, SubcategoryId = 16 },

                 new Ingredient { Id = 49, Name = "all-purpose flour", CategoryId = 5, SubcategoryId = 17 },
                 new Ingredient { Id = 50, Name = "granulated sugar", CategoryId = 5, SubcategoryId = 17 },
                 new Ingredient { Id = 51, Name = "baking powder", CategoryId = 5, SubcategoryId = 17 },

                 new Ingredient { Id = 52, Name = "salt", CategoryId = 5, SubcategoryId = 18 },
                 new Ingredient { Id = 53, Name = "black pepper", CategoryId = 5, SubcategoryId = 18 },
                 new Ingredient { Id = 54, Name = "oregano", CategoryId = 5, SubcategoryId = 18 },

                 new Ingredient { Id = 55, Name = "ketchup", CategoryId = 5, SubcategoryId = 19 },
                 new Ingredient { Id = 56, Name = "soy sauce", CategoryId = 5, SubcategoryId = 19 },
                 new Ingredient { Id = 57, Name = "mayonnaise", CategoryId = 5, SubcategoryId = 19 },

                 new Ingredient { Id = 58, Name = "potato chips", CategoryId = 5, SubcategoryId = 20 },
                 new Ingredient { Id = 59, Name = "almonds", CategoryId = 5, SubcategoryId = 20 },
                 new Ingredient { Id = 60, Name = "crackers", CategoryId = 5, SubcategoryId = 20 },

                 new Ingredient { Id = 61, Name = "pickles", CategoryId = 5, SubcategoryId = 21 },
                 new Ingredient { Id = 62, Name = "stawberry jam", CategoryId = 5, SubcategoryId = 21 },
                 new Ingredient { Id = 63, Name = "sauerkraut", CategoryId = 5, SubcategoryId = 21 },

                 new Ingredient { Id = 64, Name = "instant noodles", CategoryId = 5, SubcategoryId = 22 },
                 new Ingredient { Id = 65, Name = "canned chilli", CategoryId = 5, SubcategoryId = 22 },
                 new Ingredient { Id = 66, Name = "pizza", CategoryId = 5, SubcategoryId = 22 },

                 // Basic ingredients for Frozen Foods
                 new Ingredient { Id = 67, Name = "spinach", CategoryId = 6, SubcategoryId = 23 },
                 new Ingredient { Id = 68, Name = "green beans", CategoryId = 6, SubcategoryId = 23 },
                 new Ingredient { Id = 69, Name = "mixed vegetables", CategoryId = 6, SubcategoryId = 23 },

                 new Ingredient { Id = 70, Name = "berries", CategoryId = 6, SubcategoryId = 24 },
                 new Ingredient { Id = 71, Name = "mango chunks", CategoryId = 6, SubcategoryId = 24 },
                 new Ingredient { Id = 72, Name = "pineapple", CategoryId = 6, SubcategoryId = 24 },

                 new Ingredient { Id = 79, Name = "chicken nuggets", CategoryId = 6, SubcategoryId = 25 },
                 new Ingredient { Id = 80, Name = "fish fingers", CategoryId = 6, SubcategoryId = 25 },
                 new Ingredient { Id = 81, Name = "frozen shrimp", CategoryId = 6, SubcategoryId = 25 },

                 new Ingredient { Id = 73, Name = "pizza", CategoryId = 6, SubcategoryId = 26 },
                 new Ingredient { Id = 74, Name = "lasagna", CategoryId = 6, SubcategoryId = 26 },
                 new Ingredient { Id = 75, Name = "stir-fry kit", CategoryId = 6, SubcategoryId = 26 },

                 new Ingredient { Id = 76, Name = "vanilla ice-cream", CategoryId = 6, SubcategoryId = 27 },
                 new Ingredient { Id = 77, Name = "chocolate ice-cream", CategoryId = 6, SubcategoryId = 27 },
                 new Ingredient { Id = 78, Name = "mango sorbet", CategoryId = 6, SubcategoryId = 27 },



                 // Basic ingredients for Home & Cleaning
                 new Ingredient { Id = 82, Name = "dish soap", CategoryId = 7, SubcategoryId = 28 },
                 new Ingredient { Id = 83, Name = "laundry detergent", CategoryId = 7, SubcategoryId = 28 },
                 new Ingredient { Id = 84, Name = "washing sponge", CategoryId = 7, SubcategoryId = 28 },

                 new Ingredient { Id = 85, Name = "paper towels", CategoryId = 7, SubcategoryId = 28 },
                 new Ingredient { Id = 86, Name = "toilet paper", CategoryId = 7, SubcategoryId = 28 },
                 new Ingredient { Id = 87, Name = "shampoo", CategoryId = 7, SubcategoryId = 28 },

                 new Ingredient { Id = 88, Name = "ligh bulb 50W", CategoryId = 7, SubcategoryId = 29 },
                 new Ingredient { Id = 89, Name = "baterries AA", CategoryId = 7, SubcategoryId = 29 },
                 new Ingredient { Id = 90, Name = "baterries AAA", CategoryId = 7, SubcategoryId = 29 },


                 // Sample recipe - needed ingredients
                 new Ingredient { Id = 91, Name = "chicken thighs boneless", CategoryId = 2, SubcategoryId = 4 },
                 new Ingredient { Id = 92, Name = "black pepper coarsely ground", CategoryId = 5, SubcategoryId = 18 },
                 new Ingredient { Id = 93, Name = "clarified butter", CategoryId = 4, SubcategoryId = 12 },
                 new Ingredient { Id = 94, Name = "garlic", CategoryId = 1, SubcategoryId = 1 },
                 new Ingredient { Id = 95, Name = "ginger", CategoryId = 1, SubcategoryId = 1 },
                 new Ingredient { Id = 96, Name = "onion", CategoryId = 1, SubcategoryId = 1 }
                );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, RecipeName = "Chicken thighs in pepper", Instructions = "^^^Przygotowanie^^^***Udka pokroić na mniejsze kawałki (ok. 2 cm). Doprawić solą oraz pieprzem młotkowanym, odłożyć do zamarynowania jeśli mamy czas.***" }
                );

            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { Id = 1, RecipeId = 1, IngredientId = 91, Quantity = 700, Unit = Unit.gram }
                );
            // Sample recipe - needed recipe ingredients

        }
    }
}
