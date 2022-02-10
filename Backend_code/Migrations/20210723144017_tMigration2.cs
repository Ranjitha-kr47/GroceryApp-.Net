using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_project.Migrations
{
    public partial class tMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderitems_orders_orderid",
                table: "orderitems");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productCategories_categoryid",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_states_countries_countryid",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "PK_states",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_categoryid",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderitems",
                table: "orderitems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_countries",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "createdOn",
                table: "products");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "products");

            migrationBuilder.DropColumn(
                name: "unitPrice",
                table: "products");

            migrationBuilder.DropColumn(
                name: "unitsInStock",
                table: "products");

            migrationBuilder.DropColumn(
                name: "updatedOn",
                table: "products");

            migrationBuilder.RenameTable(
                name: "states",
                newName: "state");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "orderitems",
                newName: "orderitem");

            migrationBuilder.RenameTable(
                name: "countries",
                newName: "country");

            migrationBuilder.RenameIndex(
                name: "IX_states_countryid",
                table: "state",
                newName: "IX_state_countryid");

            migrationBuilder.RenameIndex(
                name: "IX_orderitems_orderid",
                table: "orderitem",
                newName: "IX_orderitem_orderid");

            migrationBuilder.AlterColumn<int>(
                name: "countryid",
                table: "state",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryid",
                table: "product",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "categoryid1",
                table: "product",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date_created",
                table: "product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "image_Url",
                table: "product",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_updated",
                table: "product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "unit_Price",
                table: "product",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "units_In_Stock",
                table: "product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_state",
                table: "state",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderitem",
                table: "orderitem",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_country",
                table: "country",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryid1",
                table: "product",
                column: "categoryid1");

            migrationBuilder.AddForeignKey(
                name: "FK_orderitem_orders_orderid",
                table: "orderitem",
                column: "orderid",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_product_productCategories_categoryid1",
                table: "product",
                column: "categoryid1",
                principalTable: "productCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_state_country_countryid",
                table: "state",
                column: "countryid",
                principalTable: "country",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderitem_orders_orderid",
                table: "orderitem");

            migrationBuilder.DropForeignKey(
                name: "FK_product_productCategories_categoryid1",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_state_country_countryid",
                table: "state");

            migrationBuilder.DropPrimaryKey(
                name: "PK_state",
                table: "state");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_categoryid1",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderitem",
                table: "orderitem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_country",
                table: "country");

            migrationBuilder.DropColumn(
                name: "categoryid1",
                table: "product");

            migrationBuilder.DropColumn(
                name: "date_created",
                table: "product");

            migrationBuilder.DropColumn(
                name: "image_Url",
                table: "product");

            migrationBuilder.DropColumn(
                name: "last_updated",
                table: "product");

            migrationBuilder.DropColumn(
                name: "unit_Price",
                table: "product");

            migrationBuilder.DropColumn(
                name: "units_In_Stock",
                table: "product");

            migrationBuilder.RenameTable(
                name: "state",
                newName: "states");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "orderitem",
                newName: "orderitems");

            migrationBuilder.RenameTable(
                name: "country",
                newName: "countries");

            migrationBuilder.RenameIndex(
                name: "IX_state_countryid",
                table: "states",
                newName: "IX_states_countryid");

            migrationBuilder.RenameIndex(
                name: "IX_orderitem_orderid",
                table: "orderitems",
                newName: "IX_orderitems_orderid");

            migrationBuilder.AlterColumn<int>(
                name: "countryid",
                table: "states",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "categoryid",
                table: "products",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdOn",
                table: "products",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "unitPrice",
                table: "products",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "unitsInStock",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedOn",
                table: "products",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_states",
                table: "states",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderitems",
                table: "orderitems",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_countries",
                table: "countries",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryid",
                table: "products",
                column: "categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_orderitems_orders_orderid",
                table: "orderitems",
                column: "orderid",
                principalTable: "orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productCategories_categoryid",
                table: "products",
                column: "categoryid",
                principalTable: "productCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_states_countries_countryid",
                table: "states",
                column: "countryid",
                principalTable: "countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
