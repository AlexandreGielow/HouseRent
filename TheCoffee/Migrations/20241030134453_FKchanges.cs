using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffee.Migrations
{
    /// <inheritdoc />
    public partial class FKchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Store_PropertyId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Store_StoreId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Store_StoreId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_People_PersonId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreEquipments_Store_PropertyId",
                table: "StoreEquipments");

            migrationBuilder.DropTable(
                name: "ProductsCharacteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "StoreEquipments",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreEquipments_PropertyId",
                table: "StoreEquipments",
                newName: "IX_StoreEquipments_StoreId");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "Adresses",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_PropertyId",
                table: "Adresses",
                newName: "IX_Adresses_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Store_PersonId",
                table: "Stores",
                newName: "IX_Stores_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "UnitOfMesure",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CharacteristicProduct",
                columns: table => new
                {
                    CharacteristicsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacteristicProduct", x => new { x.CharacteristicsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CharacteristicProduct_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacteristicProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacteristicProduct_ProductsId",
                table: "CharacteristicProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Stores_StoreId",
                table: "Adresses",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Stores_StoreId",
                table: "Photos",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreEquipments_Stores_StoreId",
                table: "StoreEquipments",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Stores_StoreId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Stores_StoreId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreEquipments_Stores_StoreId",
                table: "StoreEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores");

            migrationBuilder.DropTable(
                name: "CharacteristicProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "UnitOfMesure",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "StoreEquipments",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreEquipments_StoreId",
                table: "StoreEquipments",
                newName: "IX_StoreEquipments_PropertyId");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Adresses",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_StoreId",
                table: "Adresses",
                newName: "IX_Adresses_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_PersonId",
                table: "Store",
                newName: "IX_Store_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductsCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacteristicId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsCharacteristics_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCharacteristics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristics_CharacteristicId",
                table: "ProductsCharacteristics",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristics_ProductId",
                table: "ProductsCharacteristics",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Store_PropertyId",
                table: "Adresses",
                column: "PropertyId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Store_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Store_StoreId",
                table: "Photos",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_People_PersonId",
                table: "Store",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreEquipments_Store_PropertyId",
                table: "StoreEquipments",
                column: "PropertyId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
