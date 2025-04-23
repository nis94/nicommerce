using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nicommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DeteleListPriceAddCategoryFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListPrice",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "ListPrice",
                table: "Products",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ListPrice",
                value: 49.990000000000002);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ListPrice",
                value: 59.990000000000002);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ListPrice",
                value: 39.990000000000002);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ListPrice",
                value: 29.989999999999998);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ListPrice",
                value: 69.989999999999995);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ListPrice",
                value: 79.989999999999995);
        }
    }
}
