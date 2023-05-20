using Microsoft.EntityFrameworkCore.Migrations;

namespace EFM_Project.Migrations
{
    public partial class ingredient_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredient_image",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredient_image",
                table: "Ingredients");
        }
    }
}
