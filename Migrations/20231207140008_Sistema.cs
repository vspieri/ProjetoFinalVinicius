using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalVinicius.Migrations
{
    public partial class Sistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ObservacaoRealizadoId",
                table: "ProcedimentoRealizado",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ObservacaoRealizadoId",
                table: "ProcedimentoRealizado",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
