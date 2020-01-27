using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Groliapp.Migrations
{
    public partial class migpriv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssociativeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssociatedPrivUserId = table.Column<string>(nullable: true),
                    GroceryListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociativeEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociativeEntities_AspNetUsers_AssociatedPrivUserId",
                        column: x => x.AssociatedPrivUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssociativeEntities_GroceryLists_GroceryListId",
                        column: x => x.GroceryListId,
                        principalTable: "GroceryLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociativeEntities_AssociatedPrivUserId",
                table: "AssociativeEntities",
                column: "AssociatedPrivUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociativeEntities_GroceryListId",
                table: "AssociativeEntities",
                column: "GroceryListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociativeEntities");
        }
    }
}
