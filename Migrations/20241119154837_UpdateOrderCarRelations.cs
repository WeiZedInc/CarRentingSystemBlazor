using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentingSystemBlazor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderCarRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarID",
                table: "Orders",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cars_CarID",
                table: "Orders",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cars_CarID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CarID",
                table: "Orders");
        }
    }
}
