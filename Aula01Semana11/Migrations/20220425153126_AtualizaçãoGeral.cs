using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AtualizaçãoGeral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_ImovelProprietario_Imoveis_ImoveisId",
                table: "ImovelProprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imoveis",
                table: "Imoveis");

            migrationBuilder.RenameTable(
                name: "Imoveis",
                newName: "imoveis");

            migrationBuilder.RenameColumn(
                name: "valor_condominio",
                table: "imoveis",
                newName: "valor-condominio");

            migrationBuilder.RenameColumn(
                name: "descicao_curta",
                table: "imoveis",
                newName: "descricao_curta");

            migrationBuilder.RenameIndex(
                name: "IX_Imoveis_EnderecoId",
                table: "imoveis",
                newName: "IX_imoveis_EnderecoId");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "imoveis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imoveis",
                table: "imoveis",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImovelProprietario_imoveis_ImoveisId",
                table: "ImovelProprietario",
                column: "ImoveisId",
                principalTable: "imoveis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_ImovelProprietario_imoveis_ImoveisId",
                table: "ImovelProprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imoveis",
                table: "imoveis");

            migrationBuilder.RenameTable(
                name: "imoveis",
                newName: "Imoveis");

            migrationBuilder.RenameColumn(
                name: "valor-condominio",
                table: "Imoveis",
                newName: "valor_condominio");

            migrationBuilder.RenameColumn(
                name: "descricao_curta",
                table: "Imoveis",
                newName: "descicao_curta");

            migrationBuilder.RenameIndex(
                name: "IX_imoveis_EnderecoId",
                table: "Imoveis",
                newName: "IX_Imoveis_EnderecoId");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Imoveis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imoveis",
                table: "Imoveis",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImovelProprietario_Imoveis_ImoveisId",
                table: "ImovelProprietario",
                column: "ImoveisId",
                principalTable: "Imoveis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
