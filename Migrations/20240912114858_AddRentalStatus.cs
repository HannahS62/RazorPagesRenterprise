using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesRenterprise.Migrations
{
    /// <inheritdoc />
    public partial class AddRentalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rental");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rental",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
