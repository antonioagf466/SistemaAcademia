using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class add_matricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Aluno");
        }
    }
}
