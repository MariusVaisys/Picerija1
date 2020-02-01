using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Picerija.Migrations
{
    public partial class PridetaUzsakymas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uzsakymai",
                columns: table => new
                {
                    UzsakymasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vardas = table.Column<string>(nullable: true),
                    Adresas = table.Column<string>(nullable: true),
                    TelefonoNumeris = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PilnasUzsakymas = table.Column<decimal>(nullable: false),
                    UzsakytaLaikas = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzsakymai", x => x.UzsakymasId);
                });

            migrationBuilder.CreateTable(
                name: "UzsakymoInfos",
                columns: table => new
                {
                    UzsakymoInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UzsakymoId = table.Column<int>(nullable: false),
                    PicaId = table.Column<int>(nullable: false),
                    Kiekis = table.Column<int>(nullable: false),
                    Kaina = table.Column<decimal>(nullable: false),
                    UzsakymasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UzsakymoInfos", x => x.UzsakymoInfoId);
                    table.ForeignKey(
                        name: "FK_UzsakymoInfos_Picos_PicaId",
                        column: x => x.PicaId,
                        principalTable: "Picos",
                        principalColumn: "PicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UzsakymoInfos_Uzsakymai_UzsakymasId",
                        column: x => x.UzsakymasId,
                        principalTable: "Uzsakymai",
                        principalColumn: "UzsakymasId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UzsakymoInfos_PicaId",
                table: "UzsakymoInfos",
                column: "PicaId");

            migrationBuilder.CreateIndex(
                name: "IX_UzsakymoInfos_UzsakymasId",
                table: "UzsakymoInfos",
                column: "UzsakymasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UzsakymoInfos");

            migrationBuilder.DropTable(
                name: "Uzsakymai");
        }
    }
}
