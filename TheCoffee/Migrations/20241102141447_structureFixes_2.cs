using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffee.Migrations
{
    /// <inheritdoc />
    public partial class structureFixes_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Stores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_People_PersonId",
                table: "Stores",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
