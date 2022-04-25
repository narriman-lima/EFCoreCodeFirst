using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraEnderecoNovoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos-sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos-sistema",
                table: "enderecos-sistema");

            migrationBuilder.RenameTable(
                name: "enderecos-sistema",
                newName: "enderecos_sistema");

            migrationBuilder.RenameColumn(
                name: "UF",
                table: "enderecos_sistema",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "enderecos_sistema",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Referencia",
                table: "enderecos_sistema",
                newName: "referencia");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "enderecos_sistema",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "enderecos_sistema",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "enderecos_sistema",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "enderecos_sistema",
                newName: "bairro");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "enderecos_sistema",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "enderecos_sistema",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "referencia",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "enderecos_sistema",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema");

            migrationBuilder.RenameTable(
                name: "enderecos_sistema",
                newName: "enderecos-sistema");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "enderecos-sistema",
                newName: "UF");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "enderecos-sistema",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "referencia",
                table: "enderecos-sistema",
                newName: "Referencia");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "enderecos-sistema",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "enderecos-sistema",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "enderecos-sistema",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "enderecos-sistema",
                newName: "Bairro");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos-sistema",
                table: "enderecos-sistema",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos-sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos-sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
