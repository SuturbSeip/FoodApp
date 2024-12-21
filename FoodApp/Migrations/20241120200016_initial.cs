using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipeName = table.Column<string>(type: "TEXT", nullable: false),
                    Instructions = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubcategoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IngredientId = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<float>(type: "REAL", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Greengrocer's" },
                    { 2, "Butchery" },
                    { 3, "Bakery" },
                    { 4, "Dairy & Eggs" },
                    { 5, "Pantry" },
                    { 6, "Frozen Foods" },
                    { 7, "Home & Cleaning" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Instructions", "RecipeName" },
                values: new object[] { 1, "Przygotować kurczaka.", "Chicken thighs in pepper" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Vegetables" },
                    { 2, 1, "Fruits" },
                    { 3, 1, "Herbs" },
                    { 4, 2, "Meats" },
                    { 5, 2, "Deli Meats" },
                    { 6, 2, "Seafoods" },
                    { 7, 3, "Breads" },
                    { 8, 3, "Cakes and Pastries" },
                    { 9, 3, "Tortillas and Flatbreads" },
                    { 10, 4, "Milks and Creams" },
                    { 11, 4, "Yogurts and Kefirs" },
                    { 12, 4, "Butters and Margarines" },
                    { 13, 4, "Eggs" },
                    { 14, 4, "Cheeses" },
                    { 15, 5, "Grains & Pastas" },
                    { 16, 5, "Canned Goods" },
                    { 17, 5, "Baking Suplies" },
                    { 18, 5, "Spices" },
                    { 19, 5, "Sauces and Condiments" },
                    { 20, 5, "Snacks" },
                    { 21, 5, "Preserved Foods" },
                    { 22, 5, "Ready Meals" },
                    { 23, 6, "Frozen Vegetables" },
                    { 24, 6, "Frozen Fruits" },
                    { 25, 6, "Frozen Meats & Seafoods" },
                    { 26, 6, "Frozen Ready Meals" },
                    { 27, 6, "Frozen Desserts" },
                    { 28, 7, "Cleaning Supplies" },
                    { 29, 7, "Hygiene Products" },
                    { 30, 7, "Other Accesories" },
                    { 31, 5, "Beverages" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CategoryId", "Name", "SubcategoryId" },
                values: new object[,]
                {
                    { 1, 1, "carrot", 1 },
                    { 2, 1, "broccoli", 1 },
                    { 3, 1, "tomatoe", 1 },
                    { 4, 1, "apple", 2 },
                    { 5, 1, "banana", 2 },
                    { 6, 1, "orange", 2 },
                    { 7, 1, "parsley", 3 },
                    { 8, 1, "basil", 3 },
                    { 9, 1, "cilantro", 3 },
                    { 10, 2, "chicken breast", 4 },
                    { 11, 2, "roast beef", 4 },
                    { 12, 2, "pork chops", 4 },
                    { 13, 2, "ham", 5 },
                    { 14, 2, "salami", 5 },
                    { 15, 2, "bacon", 5 },
                    { 16, 2, "cod", 6 },
                    { 17, 2, "trout", 6 },
                    { 18, 2, "salmon fillet", 6 },
                    { 19, 3, "sourdough", 7 },
                    { 20, 3, "wholegrain", 7 },
                    { 21, 3, "baguette", 7 },
                    { 22, 3, "croissant", 8 },
                    { 23, 3, "muffin", 8 },
                    { 24, 3, "chocolate cake", 8 },
                    { 25, 3, "wheat tortilla", 9 },
                    { 26, 3, "pita", 9 },
                    { 27, 3, "naan", 9 },
                    { 28, 4, "milk 3.2%", 10 },
                    { 29, 4, "cream 18%", 10 },
                    { 30, 4, "heavy cream 36%", 10 },
                    { 31, 4, "greek yogurt", 11 },
                    { 32, 4, "plain yogurt", 11 },
                    { 33, 4, "kefir", 11 },
                    { 34, 4, "butter", 12 },
                    { 35, 4, "salted butter", 12 },
                    { 36, 4, "margarine", 12 },
                    { 37, 4, "egg", 13 },
                    { 38, 4, "free-range egg", 13 },
                    { 39, 4, "organic egg", 13 },
                    { 40, 4, "cheddar", 14 },
                    { 41, 4, "mozarella", 14 },
                    { 42, 4, "feta", 14 },
                    { 43, 5, "spaghetti", 15 },
                    { 44, 5, "rice", 15 },
                    { 45, 5, "spelt groats", 15 },
                    { 46, 5, "canned tomatoes", 16 },
                    { 47, 5, "canned sweetcorn", 16 },
                    { 48, 5, "canned beans", 16 },
                    { 49, 5, "all-purpose flour", 17 },
                    { 50, 5, "granulated sugar", 17 },
                    { 51, 5, "baking powder", 17 },
                    { 52, 5, "salt", 18 },
                    { 53, 5, "black pepper", 18 },
                    { 54, 5, "oregano", 18 },
                    { 55, 5, "ketchup", 19 },
                    { 56, 5, "soy sauce", 19 },
                    { 57, 5, "mayonnaise", 19 },
                    { 58, 5, "potato chips", 20 },
                    { 59, 5, "almonds", 20 },
                    { 60, 5, "crackers", 20 },
                    { 61, 5, "pickles", 21 },
                    { 62, 5, "stawberry jam", 21 },
                    { 63, 5, "sauerkraut", 21 },
                    { 64, 5, "instant noodles", 22 },
                    { 65, 5, "canned chilli", 22 },
                    { 66, 5, "pizza", 22 },
                    { 67, 6, "spinach", 23 },
                    { 68, 6, "green beans", 23 },
                    { 69, 6, "mixed vegetables", 23 },
                    { 70, 6, "berries", 24 },
                    { 71, 6, "mango chunks", 24 },
                    { 72, 6, "pineapple", 24 },
                    { 73, 6, "pizza", 26 },
                    { 74, 6, "lasagna", 26 },
                    { 75, 6, "stir-fry kit", 26 },
                    { 76, 6, "vanilla ice-cream", 27 },
                    { 77, 6, "chocolate ice-cream", 27 },
                    { 78, 6, "mango sorbet", 27 },
                    { 79, 6, "chicken nuggets", 25 },
                    { 80, 6, "fish fingers", 25 },
                    { 81, 6, "frozen shrimp", 25 },
                    { 82, 7, "dish soap", 28 },
                    { 83, 7, "laundry detergent", 28 },
                    { 84, 7, "washing sponge", 28 },
                    { 85, 7, "paper towels", 28 },
                    { 86, 7, "toilet paper", 28 },
                    { 87, 7, "shampoo", 28 },
                    { 88, 7, "ligh bulb 50W", 29 },
                    { 89, 7, "baterries AA", 29 },
                    { 90, 7, "baterries AAA", 29 },
                    { 91, 2, "chicken thighs boneless", 4 },
                    { 92, 5, "black pepper coarsely ground", 18 },
                    { 93, 4, "clarified butter", 12 },
                    { 94, 1, "garlic", 1 },
                    { 95, 1, "ginger", 1 },
                    { 96, 1, "onion", 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientId", "Quantity", "RecipeId", "Unit" },
                values: new object[] { 1, 91, 700f, 1, "gram" });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CategoryId",
                table: "Ingredients",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_SubcategoryId",
                table: "Ingredients",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
