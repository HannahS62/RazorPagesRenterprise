using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesRenterprise.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Vehicle",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Vehicle");
        }
    }
}
