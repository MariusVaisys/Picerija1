using Microsoft.EntityFrameworkCore.Migrations;

namespace Picerija.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rusys",
                columns: table => new
                {
                    RusisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RusisPavadinimas = table.Column<string>(nullable: true),
                    Aprasymas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rusys", x => x.RusisId);
                });

            migrationBuilder.CreateTable(
                name: "Picos",
                columns: table => new
                {
                    PicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(nullable: true),
                    Sudetis = table.Column<string>(nullable: true),
                    Alergenai = table.Column<string>(nullable: true),
                    Kaina = table.Column<decimal>(nullable: false),
                    ImageThumnailUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Akcija = table.Column<bool>(nullable: false),
                    Pagaminta = table.Column<bool>(nullable: false),
                    RusisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picos", x => x.PicaId);
                    table.ForeignKey(
                        name: "FK_Picos_Rusys_RusisId",
                        column: x => x.RusisId,
                        principalTable: "Rusys",
                        principalColumn: "RusisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Picos_RusisId",
                table: "Picos",
                column: "RusisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Picos");

            migrationBuilder.DropTable(
                name: "Rusys");
        }
    }
}
