using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula01Semana11.Migrations
{
    public partial class AlteraRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proprietarios_Imoveis_ImovelId",
                table: "Proprietarios");

            migrationBuilder.DropIndex(
                name: "IX_Proprietarios_ImovelId",
                table: "Proprietarios");

            migrationBuilder.DropColumn(
                name: "ImovelId",
                table: "Proprietarios");

            migrationBuilder.CreateTable(
                name: "ImovelProprietario",
                columns: table => new
                {
                    ImoveisId = table.Column<int>(type: "int", nullable: false),
                    ProprietariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImovelProprietario", x => new { x.ImoveisId, x.ProprietariosId });
                    table.ForeignKey(
                        name: "FK_ImovelProprietario_Imoveis_ImoveisId",
                        column: x => x.ImoveisId,
                        principalTable: "Imoveis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImovelProprietario_Proprietarios_ProprietariosId",
                        column: x => x.ProprietariosId,
                        principalTable: "Proprietarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImovelProprietario_ProprietariosId",
                table: "ImovelProprietario",
                column: "ProprietariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImovelProprietario");

            migrationBuilder.AddColumn<int>(
                name: "ImovelId",
                table: "Proprietarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proprietarios_ImovelId",
                table: "Proprietarios",
                column: "ImovelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietarios_Imoveis_ImovelId",
                table: "Proprietarios",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "id");
        }
    }
}
