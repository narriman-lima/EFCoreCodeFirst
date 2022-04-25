using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraNomeTabelaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Proprietario_ProprietarioId",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proprietario",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contato",
                table: "Contato");

            migrationBuilder.RenameTable(
                name: "Proprietario",
                newName: "Proprietarios");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "enderecos-sistema");

            migrationBuilder.RenameTable(
                name: "Contato",
                newName: "Contatos");

            migrationBuilder.RenameIndex(
                name: "IX_Proprietario_ImovelId",
                table: "Proprietarios",
                newName: "IX_Proprietarios_ImovelId");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_ProprietarioId",
                table: "Contatos",
                newName: "IX_Contatos_ProprietarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proprietarios",
                table: "Proprietarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos-sistema",
                table: "enderecos-sistema",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Proprietarios_ProprietarioId",
                table: "Contatos",
                column: "ProprietarioId",
                principalTable: "Proprietarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos-sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos-sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietarios_Imoveis_ImovelId",
                table: "Proprietarios",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Proprietarios_ProprietarioId",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos-sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietarios_Imoveis_ImovelId",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proprietarios",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos-sistema",
                table: "enderecos-sistema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.RenameTable(
                name: "Proprietarios",
                newName: "Proprietario");

            migrationBuilder.RenameTable(
                name: "enderecos-sistema",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Contatos",
                newName: "Contato");

            migrationBuilder.RenameIndex(
                name: "IX_Proprietarios_ImovelId",
                table: "Proprietario",
                newName: "IX_Proprietario_ImovelId");

            migrationBuilder.RenameIndex(
                name: "IX_Contatos_ProprietarioId",
                table: "Contato",
                newName: "IX_Contato_ProprietarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proprietario",
                table: "Proprietario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contato",
                table: "Contato",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Proprietario_ProprietarioId",
                table: "Contato",
                column: "ProprietarioId",
                principalTable: "Proprietario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "id");
        }
    }
}
