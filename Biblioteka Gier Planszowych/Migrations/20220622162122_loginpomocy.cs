using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteka_Gier_Planszowych.Migrations
{
    public partial class loginpomocy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UzytkownikId",
                table: "Gra_Planszowa");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Gra_Planszowa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Gra_Planszowa");

            migrationBuilder.AddColumn<int>(
                name: "UzytkownikId",
                table: "Gra_Planszowa",
                type: "INTEGER",
                nullable: true);
        }
    }
}
