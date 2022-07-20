using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRent.Migrations
{
    public partial class AddColunasEChaves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Adresses_AdressId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_People_OwnerId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyHighlights_Properties_PropertyId",
                table: "PropertyHighlights");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRulesAcessibility_Properties_PropertyId",
                table: "PropertyRulesAcessibility");

            migrationBuilder.DropIndex(
                name: "IX_Properties_AdressId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Properties",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties",
                newName: "IX_Properties_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyRulesAcessibility",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyHighlights",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Amenities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_PropertyId",
                table: "Amenities",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_PropertyId",
                table: "Adresses",
                column: "PropertyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Properties_PropertyId",
                table: "Adresses",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Properties_PropertyId",
                table: "Amenities",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_People_PersonId",
                table: "Properties",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyHighlights_Properties_PropertyId",
                table: "PropertyHighlights",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRulesAcessibility_Properties_PropertyId",
                table: "PropertyRulesAcessibility",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Properties_PropertyId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Properties_PropertyId",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_People_PersonId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyHighlights_Properties_PropertyId",
                table: "PropertyHighlights");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyRulesAcessibility_Properties_PropertyId",
                table: "PropertyRulesAcessibility");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_PropertyId",
                table: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_PropertyId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Properties",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PersonId",
                table: "Properties",
                newName: "IX_Properties_OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyRulesAcessibility",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "PropertyHighlights",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AdressId",
                table: "Properties",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Adresses_AdressId",
                table: "Properties",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_People_OwnerId",
                table: "Properties",
                column: "OwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyHighlights_Properties_PropertyId",
                table: "PropertyHighlights",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyRulesAcessibility_Properties_PropertyId",
                table: "PropertyRulesAcessibility",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }
    }
}
