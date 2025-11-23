using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Migrations
{
    public partial class AddSalaToEquipamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Equipamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipamento_SalaId",
                table: "Equipamento",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamento_Sala_SalaId",
                table: "Equipamento",
                column: "SalaId",
                principalTable: "Sala",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamento_Sala_SalaId",
                table: "Equipamento");

            migrationBuilder.DropIndex(
                name: "IX_Equipamento_SalaId",
                table: "Equipamento");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Equipamento");
        }
    }
}
