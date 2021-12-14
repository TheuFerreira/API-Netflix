using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix_Api.Migrations
{
    public partial class UpdateTypePaymentMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypePayment",
                table: "payment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypePayment",
                table: "payment");
        }
    }
}
