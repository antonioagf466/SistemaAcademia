using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class seila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Aula_AulaId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_AulaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "AulaId",
                table: "Aluno");

            migrationBuilder.CreateTable(
                name: "AlunoAula",
                columns: table => new
                {
                    AlunosId = table.Column<int>(type: "int", nullable: false),
                    AulasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoAula", x => new { x.AlunosId, x.AulasId });
                    table.ForeignKey(
                        name: "FK_AlunoAula_Aluno_AlunosId",
                        column: x => x.AlunosId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoAula_Aula_AulasId",
                        column: x => x.AulasId,
                        principalTable: "Aula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoAula_AulasId",
                table: "AlunoAula",
                column: "AulasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoAula");

            migrationBuilder.AddColumn<int>(
                name: "AulaId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_AulaId",
                table: "Aluno",
                column: "AulaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Aula_AulaId",
                table: "Aluno",
                column: "AulaId",
                principalTable: "Aula",
                principalColumn: "Id");
        }
    }
}
