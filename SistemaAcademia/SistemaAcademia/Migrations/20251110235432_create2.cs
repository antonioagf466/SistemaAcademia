using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class create2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Matricula_MatriculaId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_MatriculaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "MatriculaId",
                table: "Aluno");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Matricula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "Matricula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Aula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Aluno",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AulaId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_AlunoId",
                table: "Matricula",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_PlanoId",
                table: "Matricula",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_ProfessorId",
                table: "Aula",
                column: "ProfessorId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Aula_Professor_ProfessorId",
                table: "Aula",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Aluno_AlunoId",
                table: "Matricula",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Plano_PlanoId",
                table: "Matricula",
                column: "PlanoId",
                principalTable: "Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Aula_AulaId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Aula_Professor_ProfessorId",
                table: "Aula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Aluno_AlunoId",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Plano_PlanoId",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Matricula_AlunoId",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Matricula_PlanoId",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Aula_ProfessorId",
                table: "Aula");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_AulaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Aula");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "AulaId",
                table: "Aluno");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Matricula",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Matricula",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MatriculaId",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_MatriculaId",
                table: "Aluno",
                column: "MatriculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Matricula_MatriculaId",
                table: "Aluno",
                column: "MatriculaId",
                principalTable: "Matricula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
