using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesRenterprise.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkshopMechanic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mechanic",
                table: "Workshop",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mechanic",
                table: "Workshop");
        }
    }
}
