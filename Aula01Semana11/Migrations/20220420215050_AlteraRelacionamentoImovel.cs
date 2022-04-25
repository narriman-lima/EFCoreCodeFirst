using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraRelacionamentoImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
