using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheCoffee.Migrations
{
    /// <inheritdoc />
    public partial class typingfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "Products",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Products");
        }
    }
}
