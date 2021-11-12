using Microsoft.EntityFrameworkCore.Migrations;

namespace BekeTanszekBistro.MenuBoard.Api.Migrations
{
    public partial class SeedCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Leves')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Főétel')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Frissensült')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Köret')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Tészták')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Vega / Érzékenyek')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Saláták / Dresszing')");
            migrationBuilder.Sql("INSERT INTO categories (name) VALUES ('Extra ajánlat')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categories;");
        }
    }
}
