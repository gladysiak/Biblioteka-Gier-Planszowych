using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteka_Gier_Planszowych.Migrations
{
    public partial class Biblio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UzytkownikId",
                table: "Gra_Planszowa",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UzytkownikId",
                table: "Gra_Planszowa");
        }
    }
}
