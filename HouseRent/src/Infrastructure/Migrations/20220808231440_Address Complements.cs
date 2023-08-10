using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRent.Migrations
{
    public partial class AddressComplements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressName",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressName",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Adresses");
        }
    }
}
