using Microsoft.EntityFrameworkCore.Migrations;

namespace Groliapp.Migrations
{
    public partial class migpriv9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "GroceryLists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "GroceryLists");
        }
    }
}
