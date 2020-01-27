using Microsoft.EntityFrameworkCore.Migrations;

namespace Groliapp.Migrations
{
    public partial class migpriv7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssociativeEntities_AspNetUsers_AssociatedPrivUserId",
                table: "AssociativeEntities");

            migrationBuilder.DropIndex(
                name: "IX_AssociativeEntities_AssociatedPrivUserId",
                table: "AssociativeEntities");

            migrationBuilder.RenameColumn(
                name: "AssociatedPrivUserId",
                table: "AssociativeEntities",
                newName: "PrivUserId");

            migrationBuilder.AlterColumn<string>(
                name: "PrivUserId",
                table: "AssociativeEntities",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrivUserEmail",
                table: "AssociativeEntities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrivUserEmail",
                table: "AssociativeEntities");

            migrationBuilder.RenameColumn(
                name: "PrivUserId",
                table: "AssociativeEntities",
                newName: "AssociatedPrivUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AssociatedPrivUserId",
                table: "AssociativeEntities",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssociativeEntities_AssociatedPrivUserId",
                table: "AssociativeEntities",
                column: "AssociatedPrivUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssociativeEntities_AspNetUsers_AssociatedPrivUserId",
                table: "AssociativeEntities",
                column: "AssociatedPrivUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
