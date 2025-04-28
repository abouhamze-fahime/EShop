using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class first1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orderSummaries",
                table: "orderSummaries");

            migrationBuilder.RenameTable(
                name: "orderSummaries",
                newName: "OrderSummaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderSummaries",
                table: "OrderSummaries",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderSummaries",
                table: "OrderSummaries");

            migrationBuilder.RenameTable(
                name: "OrderSummaries",
                newName: "orderSummaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderSummaries",
                table: "orderSummaries",
                column: "Id");
        }
    }
}
