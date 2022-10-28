using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalogMvc.Infra.Data.Migrations
{
    public partial class cnpjnEW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJFornecedor",
                table: "Products",
                newName: "CNPJProvider");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJProvider",
                table: "Products",
                newName: "CNPJFornecedor");
        }
    }
}
