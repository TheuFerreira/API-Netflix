using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix_Api.Migrations
{
    public partial class UpdatePaymentMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "year_date",
                table: "payment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year_date",
                table: "payment");
        }
    }
}
