using Microsoft.EntityFrameworkCore.Migrations;

namespace Groliapp.Migrations
{
    public partial class migass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssociativeEntities_GroceryLists_GroceryListId",
                table: "AssociativeEntities");

            migrationBuilder.AlterColumn<int>(
                name: "GroceryListId",
                table: "AssociativeEntities",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AssociativeEntities_GroceryLists_GroceryListId",
                table: "AssociativeEntities",
                column: "GroceryListId",
                principalTable: "GroceryLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssociativeEntities_GroceryLists_GroceryListId",
                table: "AssociativeEntities");

            migrationBuilder.AlterColumn<int>(
                name: "GroceryListId",
                table: "AssociativeEntities",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AssociativeEntities_GroceryLists_GroceryListId",
                table: "AssociativeEntities",
                column: "GroceryListId",
                principalTable: "GroceryLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
