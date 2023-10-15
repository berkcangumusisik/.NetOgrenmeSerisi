using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03.EfCoreCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class categoryadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductTb");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "ProductTb",
                newName: "IX_ProductTb_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTb",
                table: "ProductTb",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTb_Category_CategoryId",
                table: "ProductTb",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTb_Category_CategoryId",
                table: "ProductTb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTb",
                table: "ProductTb");

            migrationBuilder.RenameTable(
                name: "ProductTb",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTb_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
