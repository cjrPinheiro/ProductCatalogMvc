using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalogMvc.Infra.Data.Migrations
{
    public partial class cnpj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CNPJFornecedor",
                table: "Products",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJFornecedor",
                table: "Products");
        }
    }
}
