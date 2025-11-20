using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class backendpronto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Aluno");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Pagamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipamentoId",
                table: "Manutencao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "Aluno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_AlunoId",
                table: "Pagamento",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_EquipamentoId",
                table: "Manutencao",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_PlanoId",
                table: "Aluno",
                column: "PlanoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Plano_PlanoId",
                table: "Aluno",
                column: "PlanoId",
                principalTable: "Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Equipamento_EquipamentoId",
                table: "Manutencao",
                column: "EquipamentoId",
                principalTable: "Equipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Aluno_AlunoId",
                table: "Pagamento",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Plano_PlanoId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Equipamento_EquipamentoId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Aluno_AlunoId",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_AlunoId",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Manutencao_EquipamentoId",
                table: "Manutencao");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_PlanoId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "EquipamentoId",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "Aluno");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Aluno",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
