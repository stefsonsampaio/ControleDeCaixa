using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeCaixa.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor_inicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Valor_final = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Data_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_fechamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Justificativa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    Transaca_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caixa_id = table.Column<int>(type: "int", nullable: false),
                    Data_transacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_transacao = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    valor_transacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacao", x => x.Transaca_id);
                    table.ForeignKey(
                        name: "FK_Transacao_Caixa_Caixa_id",
                        column: x => x.Caixa_id,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacao_Caixa_id",
                table: "Transacao",
                column: "Caixa_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacao");

            migrationBuilder.DropTable(
                name: "Caixa");
        }
    }
}
