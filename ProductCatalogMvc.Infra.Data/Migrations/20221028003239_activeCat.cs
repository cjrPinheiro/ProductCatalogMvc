using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalogMvc.Infra.Data.Migrations
{
    public partial class activeCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Categories");
        }
    }
}
