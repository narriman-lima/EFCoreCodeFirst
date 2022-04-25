using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraNomeColunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Imoveis",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Imoveis",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Imoveis",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Imoveis",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ValorCondominio",
                table: "Imoveis",
                newName: "valor_condominio");

            migrationBuilder.RenameColumn(
                name: "DescricaoLonga",
                table: "Imoveis",
                newName: "descricao_longa");

            migrationBuilder.RenameColumn(
                name: "DescricaoCurta",
                table: "Imoveis",
                newName: "descicao_curta");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Imoveis",
                newName: "data_criacao");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Imoveis",
                newName: "data_atualizacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Imoveis",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Imoveis",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Imoveis",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Imoveis",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor_condominio",
                table: "Imoveis",
                newName: "ValorCondominio");

            migrationBuilder.RenameColumn(
                name: "descricao_longa",
                table: "Imoveis",
                newName: "DescricaoLonga");

            migrationBuilder.RenameColumn(
                name: "descicao_curta",
                table: "Imoveis",
                newName: "DescricaoCurta");

            migrationBuilder.RenameColumn(
                name: "data_criacao",
                table: "Imoveis",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "data_atualizacao",
                table: "Imoveis",
                newName: "DataAtualizacao");
        }
    }
}
