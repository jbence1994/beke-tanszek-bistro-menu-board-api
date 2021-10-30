using Microsoft.EntityFrameworkCore.Migrations;

namespace BekeTanszekBistro.MenuBoard.Api.Migrations
{
    public partial class SeedTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Levesek')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Főételek')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Vegetáriánus')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Frissensültek')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Tészták')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Köretek')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Desszert')");
            migrationBuilder.Sql("INSERT INTO types (name) VALUES ('Saláták')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM types;");
        }
    }
}
