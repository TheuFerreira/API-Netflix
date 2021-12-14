using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix_Api.Migrations
{
    public partial class AddedPaymentMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_payment",
                table: "Account",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    id_payment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    month_date = table.Column<short>(type: "smallint", nullable: false),
                    number_card = table.Column<long>(type: "bigint", maxLength: 19, nullable: false),
                    cvv = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    type_payment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.id_payment);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Account_id_payment",
                table: "Account",
                column: "id_payment");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_payment_id_payment",
                table: "Account",
                column: "id_payment",
                principalTable: "payment",
                principalColumn: "id_payment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_payment_id_payment",
                table: "Account");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropIndex(
                name: "IX_Account_id_payment",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "id_payment",
                table: "Account");
        }
    }
}
