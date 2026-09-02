using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastingSolution.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Local = table.Column<string>(type: "TEXT", nullable: false),
                    Cliente = table.Column<string>(type: "TEXT", nullable: false),
                    DetalhesEvento = table.Column<string>(type: "TEXT", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorPromotores = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorCobrado = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    FuncaoPrincipal = table.Column<string>(type: "TEXT", nullable: false),
                    Altura = table.Column<int>(type: "INTEGER", nullable: false),
                    CorOlhos = table.Column<string>(type: "TEXT", nullable: false),
                    CorCabelo = table.Column<string>(type: "TEXT", nullable: false),
                    Genero = table.Column<int>(type: "INTEGER", nullable: false),
                    TamanhoCamiseta = table.Column<string>(type: "TEXT", nullable: false),
                    TamanhoCalca = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: false),
                    IsFavorito = table.Column<bool>(type: "INTEGER", nullable: false),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Castings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Area = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    MaximoPromotores = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Castings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Castings_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosPromotor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PromotorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CaminhoArquivo = table.Column<string>(type: "TEXT", nullable: false),
                    TipoDocumento = table.Column<int>(type: "INTEGER", nullable: false),
                    DataUpload = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Obs = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosPromotor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentosPromotor_Promotores_PromotorId",
                        column: x => x.PromotorId,
                        principalTable: "Promotores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FotosPromotor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PromotorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CaminhoArquivo = table.Column<string>(type: "TEXT", nullable: false),
                    IsPrincipal = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ordem = table.Column<int>(type: "INTEGER", nullable: false),
                    DataUpload = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosPromotor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotosPromotor_Promotores_PromotorId",
                        column: x => x.PromotorId,
                        principalTable: "Promotores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastingPromotores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PromotorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CastingId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    FuncaoRealizada = table.Column<string>(type: "TEXT", nullable: false),
                    Ordem = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastingPromotores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastingPromotores_Castings_CastingId",
                        column: x => x.CastingId,
                        principalTable: "Castings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastingPromotores_Promotores_PromotorId",
                        column: x => x.PromotorId,
                        principalTable: "Promotores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CastingPromotorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    DataPrevista = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataPagamento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Comprovante = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_CastingPromotores_CastingPromotorId",
                        column: x => x.CastingPromotorId,
                        principalTable: "CastingPromotores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastingPromotores_CastingId",
                table: "CastingPromotores",
                column: "CastingId");

            migrationBuilder.CreateIndex(
                name: "IX_CastingPromotores_PromotorId",
                table: "CastingPromotores",
                column: "PromotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Castings_EventoId",
                table: "Castings",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosPromotor_PromotorId",
                table: "DocumentosPromotor",
                column: "PromotorId");

            migrationBuilder.CreateIndex(
                name: "IX_FotosPromotor_PromotorId",
                table: "FotosPromotor",
                column: "PromotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_CastingPromotorId",
                table: "Pagamentos",
                column: "CastingPromotorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentosPromotor");

            migrationBuilder.DropTable(
                name: "FotosPromotor");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "CastingPromotores");

            migrationBuilder.DropTable(
                name: "Castings");

            migrationBuilder.DropTable(
                name: "Promotores");

            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
