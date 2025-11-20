using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class arrumandosalaaula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sala",
                table: "Aula");

            migrationBuilder.AddColumn<int>(
                name: "AulaId",
                table: "InscricaoAula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Aula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoAula_AlunoId",
                table: "InscricaoAula",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_InscricaoAula_AulaId",
                table: "InscricaoAula",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_SalaId",
                table: "Aula",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aula_Sala_SalaId",
                table: "Aula",
                column: "SalaId",
                principalTable: "Sala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InscricaoAula_Aluno_AlunoId",
                table: "InscricaoAula",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InscricaoAula_Aula_AulaId",
                table: "InscricaoAula",
                column: "AulaId",
                principalTable: "Aula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aula_Sala_SalaId",
                table: "Aula");

            migrationBuilder.DropForeignKey(
                name: "FK_InscricaoAula_Aluno_AlunoId",
                table: "InscricaoAula");

            migrationBuilder.DropForeignKey(
                name: "FK_InscricaoAula_Aula_AulaId",
                table: "InscricaoAula");

            migrationBuilder.DropIndex(
                name: "IX_InscricaoAula_AlunoId",
                table: "InscricaoAula");

            migrationBuilder.DropIndex(
                name: "IX_InscricaoAula_AulaId",
                table: "InscricaoAula");

            migrationBuilder.DropIndex(
                name: "IX_Aula_SalaId",
                table: "Aula");

            migrationBuilder.DropColumn(
                name: "AulaId",
                table: "InscricaoAula");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Aula");

            migrationBuilder.AddColumn<string>(
                name: "Sala",
                table: "Aula",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
