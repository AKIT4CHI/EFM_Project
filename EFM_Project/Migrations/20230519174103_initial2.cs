using Microsoft.EntityFrameworkCore.Migrations;

namespace EFM_Project.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etapes",
                columns: table => new
                {
                    Etape_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etape_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etape_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etape_order = table.Column<int>(type: "int", nullable: false),
                    Meal_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapes", x => x.Etape_id);
                    table.ForeignKey(
                        name: "FK_Etapes_Meals_Meal_id",
                        column: x => x.Meal_id,
                        principalTable: "Meals",
                        principalColumn: "Meal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Feedback_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Feedback_id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Meals_Meal_id",
                        column: x => x.Meal_id,
                        principalTable: "Meals",
                        principalColumn: "Meal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredient_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Ingredient_id);
                });

            migrationBuilder.CreateTable(
                name: "Quantity",
                columns: table => new
                {
                    Etape_id = table.Column<int>(type: "int", nullable: false),
                    Ingredient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantity", x => new { x.Etape_id, x.Ingredient_id });
                    table.ForeignKey(
                        name: "FK_Quantity_Etapes_Ingredient_id",
                        column: x => x.Ingredient_id,
                        principalTable: "Etapes",
                        principalColumn: "Etape_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quantity_Ingredients_Etape_id",
                        column: x => x.Etape_id,
                        principalTable: "Ingredients",
                        principalColumn: "Ingredient_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etapes_Meal_id",
                table: "Etapes",
                column: "Meal_id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Meal_id",
                table: "Feedbacks",
                column: "Meal_id");

            migrationBuilder.CreateIndex(
                name: "IX_Quantity_Ingredient_id",
                table: "Quantity",
                column: "Ingredient_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Quantity");

            migrationBuilder.DropTable(
                name: "Etapes");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
