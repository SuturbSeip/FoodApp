﻿// <auto-generated />
using System;
using FoodApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodApp.Migrations
{
    [DbContext(typeof(IngredientDbContext))]
    [Migration("20241120200016_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("FoodApp.Model.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SubcategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "carrot",
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "broccoli",
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "tomatoe",
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "apple",
                            SubcategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Name = "banana",
                            SubcategoryId = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Name = "orange",
                            SubcategoryId = 2
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Name = "parsley",
                            SubcategoryId = 3
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Name = "basil",
                            SubcategoryId = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Name = "cilantro",
                            SubcategoryId = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Name = "chicken breast",
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Name = "roast beef",
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "pork chops",
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Name = "ham",
                            SubcategoryId = 5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Name = "salami",
                            SubcategoryId = 5
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Name = "bacon",
                            SubcategoryId = 5
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Name = "cod",
                            SubcategoryId = 6
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Name = "trout",
                            SubcategoryId = 6
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 2,
                            Name = "salmon fillet",
                            SubcategoryId = 6
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Name = "sourdough",
                            SubcategoryId = 7
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Name = "wholegrain",
                            SubcategoryId = 7
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Name = "baguette",
                            SubcategoryId = 7
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Name = "croissant",
                            SubcategoryId = 8
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            Name = "muffin",
                            SubcategoryId = 8
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            Name = "chocolate cake",
                            SubcategoryId = 8
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 3,
                            Name = "wheat tortilla",
                            SubcategoryId = 9
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 3,
                            Name = "pita",
                            SubcategoryId = 9
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 3,
                            Name = "naan",
                            SubcategoryId = 9
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            Name = "milk 3.2%",
                            SubcategoryId = 10
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            Name = "cream 18%",
                            SubcategoryId = 10
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            Name = "heavy cream 36%",
                            SubcategoryId = 10
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 4,
                            Name = "greek yogurt",
                            SubcategoryId = 11
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 4,
                            Name = "plain yogurt",
                            SubcategoryId = 11
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 4,
                            Name = "kefir",
                            SubcategoryId = 11
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 4,
                            Name = "butter",
                            SubcategoryId = 12
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 4,
                            Name = "salted butter",
                            SubcategoryId = 12
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 4,
                            Name = "margarine",
                            SubcategoryId = 12
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 4,
                            Name = "egg",
                            SubcategoryId = 13
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 4,
                            Name = "free-range egg",
                            SubcategoryId = 13
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 4,
                            Name = "organic egg",
                            SubcategoryId = 13
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 4,
                            Name = "cheddar",
                            SubcategoryId = 14
                        },
                        new
                        {
                            Id = 41,
                            CategoryId = 4,
                            Name = "mozarella",
                            SubcategoryId = 14
                        },
                        new
                        {
                            Id = 42,
                            CategoryId = 4,
                            Name = "feta",
                            SubcategoryId = 14
                        },
                        new
                        {
                            Id = 43,
                            CategoryId = 5,
                            Name = "spaghetti",
                            SubcategoryId = 15
                        },
                        new
                        {
                            Id = 44,
                            CategoryId = 5,
                            Name = "rice",
                            SubcategoryId = 15
                        },
                        new
                        {
                            Id = 45,
                            CategoryId = 5,
                            Name = "spelt groats",
                            SubcategoryId = 15
                        },
                        new
                        {
                            Id = 46,
                            CategoryId = 5,
                            Name = "canned tomatoes",
                            SubcategoryId = 16
                        },
                        new
                        {
                            Id = 47,
                            CategoryId = 5,
                            Name = "canned sweetcorn",
                            SubcategoryId = 16
                        },
                        new
                        {
                            Id = 48,
                            CategoryId = 5,
                            Name = "canned beans",
                            SubcategoryId = 16
                        },
                        new
                        {
                            Id = 49,
                            CategoryId = 5,
                            Name = "all-purpose flour",
                            SubcategoryId = 17
                        },
                        new
                        {
                            Id = 50,
                            CategoryId = 5,
                            Name = "granulated sugar",
                            SubcategoryId = 17
                        },
                        new
                        {
                            Id = 51,
                            CategoryId = 5,
                            Name = "baking powder",
                            SubcategoryId = 17
                        },
                        new
                        {
                            Id = 52,
                            CategoryId = 5,
                            Name = "salt",
                            SubcategoryId = 18
                        },
                        new
                        {
                            Id = 53,
                            CategoryId = 5,
                            Name = "black pepper",
                            SubcategoryId = 18
                        },
                        new
                        {
                            Id = 54,
                            CategoryId = 5,
                            Name = "oregano",
                            SubcategoryId = 18
                        },
                        new
                        {
                            Id = 55,
                            CategoryId = 5,
                            Name = "ketchup",
                            SubcategoryId = 19
                        },
                        new
                        {
                            Id = 56,
                            CategoryId = 5,
                            Name = "soy sauce",
                            SubcategoryId = 19
                        },
                        new
                        {
                            Id = 57,
                            CategoryId = 5,
                            Name = "mayonnaise",
                            SubcategoryId = 19
                        },
                        new
                        {
                            Id = 58,
                            CategoryId = 5,
                            Name = "potato chips",
                            SubcategoryId = 20
                        },
                        new
                        {
                            Id = 59,
                            CategoryId = 5,
                            Name = "almonds",
                            SubcategoryId = 20
                        },
                        new
                        {
                            Id = 60,
                            CategoryId = 5,
                            Name = "crackers",
                            SubcategoryId = 20
                        },
                        new
                        {
                            Id = 61,
                            CategoryId = 5,
                            Name = "pickles",
                            SubcategoryId = 21
                        },
                        new
                        {
                            Id = 62,
                            CategoryId = 5,
                            Name = "stawberry jam",
                            SubcategoryId = 21
                        },
                        new
                        {
                            Id = 63,
                            CategoryId = 5,
                            Name = "sauerkraut",
                            SubcategoryId = 21
                        },
                        new
                        {
                            Id = 64,
                            CategoryId = 5,
                            Name = "instant noodles",
                            SubcategoryId = 22
                        },
                        new
                        {
                            Id = 65,
                            CategoryId = 5,
                            Name = "canned chilli",
                            SubcategoryId = 22
                        },
                        new
                        {
                            Id = 66,
                            CategoryId = 5,
                            Name = "pizza",
                            SubcategoryId = 22
                        },
                        new
                        {
                            Id = 67,
                            CategoryId = 6,
                            Name = "spinach",
                            SubcategoryId = 23
                        },
                        new
                        {
                            Id = 68,
                            CategoryId = 6,
                            Name = "green beans",
                            SubcategoryId = 23
                        },
                        new
                        {
                            Id = 69,
                            CategoryId = 6,
                            Name = "mixed vegetables",
                            SubcategoryId = 23
                        },
                        new
                        {
                            Id = 70,
                            CategoryId = 6,
                            Name = "berries",
                            SubcategoryId = 24
                        },
                        new
                        {
                            Id = 71,
                            CategoryId = 6,
                            Name = "mango chunks",
                            SubcategoryId = 24
                        },
                        new
                        {
                            Id = 72,
                            CategoryId = 6,
                            Name = "pineapple",
                            SubcategoryId = 24
                        },
                        new
                        {
                            Id = 79,
                            CategoryId = 6,
                            Name = "chicken nuggets",
                            SubcategoryId = 25
                        },
                        new
                        {
                            Id = 80,
                            CategoryId = 6,
                            Name = "fish fingers",
                            SubcategoryId = 25
                        },
                        new
                        {
                            Id = 81,
                            CategoryId = 6,
                            Name = "frozen shrimp",
                            SubcategoryId = 25
                        },
                        new
                        {
                            Id = 73,
                            CategoryId = 6,
                            Name = "pizza",
                            SubcategoryId = 26
                        },
                        new
                        {
                            Id = 74,
                            CategoryId = 6,
                            Name = "lasagna",
                            SubcategoryId = 26
                        },
                        new
                        {
                            Id = 75,
                            CategoryId = 6,
                            Name = "stir-fry kit",
                            SubcategoryId = 26
                        },
                        new
                        {
                            Id = 76,
                            CategoryId = 6,
                            Name = "vanilla ice-cream",
                            SubcategoryId = 27
                        },
                        new
                        {
                            Id = 77,
                            CategoryId = 6,
                            Name = "chocolate ice-cream",
                            SubcategoryId = 27
                        },
                        new
                        {
                            Id = 78,
                            CategoryId = 6,
                            Name = "mango sorbet",
                            SubcategoryId = 27
                        },
                        new
                        {
                            Id = 82,
                            CategoryId = 7,
                            Name = "dish soap",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 83,
                            CategoryId = 7,
                            Name = "laundry detergent",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 84,
                            CategoryId = 7,
                            Name = "washing sponge",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 85,
                            CategoryId = 7,
                            Name = "paper towels",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 86,
                            CategoryId = 7,
                            Name = "toilet paper",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 87,
                            CategoryId = 7,
                            Name = "shampoo",
                            SubcategoryId = 28
                        },
                        new
                        {
                            Id = 88,
                            CategoryId = 7,
                            Name = "ligh bulb 50W",
                            SubcategoryId = 29
                        },
                        new
                        {
                            Id = 89,
                            CategoryId = 7,
                            Name = "baterries AA",
                            SubcategoryId = 29
                        },
                        new
                        {
                            Id = 90,
                            CategoryId = 7,
                            Name = "baterries AAA",
                            SubcategoryId = 29
                        },
                        new
                        {
                            Id = 91,
                            CategoryId = 2,
                            Name = "chicken thighs boneless",
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 92,
                            CategoryId = 5,
                            Name = "black pepper coarsely ground",
                            SubcategoryId = 18
                        },
                        new
                        {
                            Id = 93,
                            CategoryId = 4,
                            Name = "clarified butter",
                            SubcategoryId = 12
                        },
                        new
                        {
                            Id = 94,
                            CategoryId = 1,
                            Name = "garlic",
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 95,
                            CategoryId = 1,
                            Name = "ginger",
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 96,
                            CategoryId = 1,
                            Name = "onion",
                            SubcategoryId = 1
                        });
                });

            modelBuilder.Entity("FoodApp.Model.IngredientCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Greengrocer's"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Butchery"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bakery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dairy & Eggs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pantry"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Frozen Foods"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Home & Cleaning"
                        });
                });

            modelBuilder.Entity("FoodApp.Model.IngredientSubcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Herbs"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Meats"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Deli Meats"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Seafoods"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Name = "Breads"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Name = "Cakes and Pastries"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Name = "Tortillas and Flatbreads"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Name = "Milks and Creams"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Name = "Yogurts and Kefirs"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Name = "Butters and Margarines"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Name = "Eggs"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 4,
                            Name = "Cheeses"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Name = "Grains & Pastas"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Name = "Canned Goods"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Name = "Baking Suplies"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 5,
                            Name = "Spices"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 5,
                            Name = "Sauces and Condiments"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 5,
                            Name = "Snacks"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            Name = "Preserved Foods"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Name = "Ready Meals"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 5,
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 6,
                            Name = "Frozen Vegetables"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 6,
                            Name = "Frozen Fruits"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 6,
                            Name = "Frozen Meats & Seafoods"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 6,
                            Name = "Frozen Ready Meals"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            Name = "Frozen Desserts"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 7,
                            Name = "Cleaning Supplies"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 7,
                            Name = "Hygiene Products"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 7,
                            Name = "Other Accesories"
                        });
                });

            modelBuilder.Entity("FoodApp.Model.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Instructions = "Przygotować kurczaka.",
                            RecipeName = "Chicken thighs in pepper"
                        });
                });

            modelBuilder.Entity("FoodApp.Model.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IngredientId = 91,
                            Quantity = 700f,
                            RecipeId = 1,
                            Unit = "gram"
                        });
                });

            modelBuilder.Entity("FoodApp.Model.Ingredient", b =>
                {
                    b.HasOne("FoodApp.Model.IngredientCategory", "Category")
                        .WithMany("Ingredients")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodApp.Model.IngredientSubcategory", "Subcategory")
                        .WithMany("Ingredients")
                        .HasForeignKey("SubcategoryId");

                    b.Navigation("Category");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("FoodApp.Model.IngredientSubcategory", b =>
                {
                    b.HasOne("FoodApp.Model.IngredientCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FoodApp.Model.RecipeIngredient", b =>
                {
                    b.HasOne("FoodApp.Model.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodApp.Model.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodApp.Model.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("FoodApp.Model.IngredientCategory", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("FoodApp.Model.IngredientSubcategory", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("FoodApp.Model.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
