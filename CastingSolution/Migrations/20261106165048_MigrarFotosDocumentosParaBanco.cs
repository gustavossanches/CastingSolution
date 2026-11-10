using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastingSolution.Migrations
{
    /// <inheritdoc />
    public partial class MigrarFotosDocumentosParaBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CaminhoArquivo",
                table: "FotosPromotor",
                newName: "NomeArquivo");

            migrationBuilder.RenameColumn(
                name: "CaminhoArquivo",
                table: "DocumentosPromotor",
                newName: "NomeArquivo");

            migrationBuilder.AddColumn<byte[]>(
                name: "Conteudo",
                table: "FotosPromotor",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Conteudo",
                table: "DocumentosPromotor",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "FotosPromotor");

            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "DocumentosPromotor");

            migrationBuilder.RenameColumn(
                name: "NomeArquivo",
                table: "FotosPromotor",
                newName: "CaminhoArquivo");

            migrationBuilder.RenameColumn(
                name: "NomeArquivo",
                table: "DocumentosPromotor",
                newName: "CaminhoArquivo");
        }
    }
}
