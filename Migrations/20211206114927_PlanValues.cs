using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix_Api.Migrations
{
    public partial class PlanValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "plan",
                columns: new[] { "id_plan", "Price", "Quality", "Resolution", "Title" },
                values: new object[] { 1, 25.899999999999999, "Boa", "480p", "Básico" });

            migrationBuilder.InsertData(
                table: "plan",
                columns: new[] { "id_plan", "Price", "Quality", "Resolution", "Title" },
                values: new object[] { 2, 39.899999999999999, "Melhor", "1080p", "Padrão" });

            migrationBuilder.InsertData(
                table: "plan",
                columns: new[] { "id_plan", "Price", "Quality", "Resolution", "Title" },
                values: new object[] { 3, 55.899999999999999, "Superior", "4K+HDR", "Premium" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "plan",
                keyColumn: "id_plan",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "plan",
                keyColumn: "id_plan",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "plan",
                keyColumn: "id_plan",
                keyValue: 3);
        }
    }
}
