using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_project.Migrations
{
    public partial class tMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_productCategories_categoryid1",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_categoryid1",
                table: "product");

            migrationBuilder.DropColumn(
                name: "categoryid1",
                table: "product");

            migrationBuilder.AddColumn<long>(
                name: "ProductCategoryid",
                table: "product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_ProductCategoryid",
                table: "product",
                column: "ProductCategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_product_productCategories_ProductCategoryid",
                table: "product",
                column: "ProductCategoryid",
                principalTable: "productCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_productCategories_ProductCategoryid",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_ProductCategoryid",
                table: "product");

            migrationBuilder.DropColumn(
                name: "ProductCategoryid",
                table: "product");

            migrationBuilder.AddColumn<long>(
                name: "categoryid1",
                table: "product",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryid1",
                table: "product",
                column: "categoryid1");

            migrationBuilder.AddForeignKey(
                name: "FK_product_productCategories_categoryid1",
                table: "product",
                column: "categoryid1",
                principalTable: "productCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
