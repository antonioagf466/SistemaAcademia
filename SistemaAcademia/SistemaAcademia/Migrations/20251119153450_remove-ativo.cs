using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class removeativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Professor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Professor",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
