using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentingSystemBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddDamagePropertiesToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DamageCost",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "DamageDescription",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DamageCost",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DamageDescription",
                table: "Orders");
        }
    }
}
