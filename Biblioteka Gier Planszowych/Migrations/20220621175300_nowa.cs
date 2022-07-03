using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteka_Gier_Planszowych.Migrations
{
    public partial class nowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gra_Planszowa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytuł = table.Column<string>(type: "TEXT", nullable: false),
                    Wydawca = table.Column<string>(type: "TEXT", nullable: false),
                    Gatunek = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gra_Planszowa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gra_Planszowa");
        }
    }
}
