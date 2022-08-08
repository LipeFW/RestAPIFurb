using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAPIFurb.Migrations
{
    public partial class FixingIdNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ComandaId",
                table: "Comandas",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produtos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comandas",
                newName: "ComandaId");
        }
    }
}
