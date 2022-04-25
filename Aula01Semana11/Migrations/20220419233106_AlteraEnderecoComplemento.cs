using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraEnderecoComplemento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "enderecos-sistema",
                newName: "complemento");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "enderecos-sistema",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "enderecos-sistema",
                newName: "Complemento");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "enderecos-sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
