using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmoothBoardStylers.Data.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Geslacht = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Land = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Inschrijven = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantenId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klanten");
        }
    }
}
