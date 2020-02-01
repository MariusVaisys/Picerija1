using Microsoft.EntityFrameworkCore.Migrations;

namespace Picerija.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rusys",
                columns: new[] { "RusisId", "Aprasymas", "RusisPavadinimas" },
                values: new object[] { 1, null, "Astri" });

            migrationBuilder.InsertData(
                table: "Rusys",
                columns: new[] { "RusisId", "Aprasymas", "RusisPavadinimas" },
                values: new object[] { 2, null, "Vegetariska" });

            migrationBuilder.InsertData(
                table: "Rusys",
                columns: new[] { "RusisId", "Aprasymas", "RusisPavadinimas" },
                values: new object[] { 3, null, "Soti" });

            migrationBuilder.InsertData(
                table: "Picos",
                columns: new[] { "PicaId", "Akcija", "Alergenai", "ImageThumnailUrl", "ImageUrl", "Kaina", "Pagaminta", "Pavadinimas", "RusisId", "Sudetis" },
                values: new object[,]
                {
                    { 2, true, "A,B,C", null, "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\salami.png", 6.99m, true, "Salami", 1, "Padas, suris, Salami" },
                    { 4, true, "A,B,C", null, "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\vegetariana.png", 7.99m, true, "Vegetariana", 2, "Padas, suris, Darzoves" },
                    { 1, true, "A,B,C", null, "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\margarita.png", 7.99m, true, "Margarita", 3, "Padas, suris, Desreles" },
                    { 3, true, "A,B,C", null, "C:\\Users\\Marius\\Desktop\\C#Vakariniai mokymai\\Picerija\\Picerija\\wwwroot\\paveiksliukai\\margarita.png", 7.99m, true, "Taiti", 3, "Padas, suris, Taiti" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Picos",
                keyColumn: "PicaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Picos",
                keyColumn: "PicaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Picos",
                keyColumn: "PicaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Picos",
                keyColumn: "PicaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rusys",
                keyColumn: "RusisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rusys",
                keyColumn: "RusisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rusys",
                keyColumn: "RusisId",
                keyValue: 3);
        }
    }
}
