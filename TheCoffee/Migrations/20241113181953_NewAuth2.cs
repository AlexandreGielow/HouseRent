using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffee.Migrations
{
    /// <inheritdoc />
    public partial class NewAuth2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "IdentityUserId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
