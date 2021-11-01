using Microsoft.EntityFrameworkCore.Migrations;

namespace BekeTanszekBistro.MenuBoard.Api.Migrations
{
    public partial class AddPriceColumnToMealsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "meals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "meals");
        }
    }
}
