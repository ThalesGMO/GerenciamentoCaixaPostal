using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GerenciamentoCaixaPostal.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTabelasCaixaPostal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaixasStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CobrancasStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CobrancasStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdClienteStatus = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesStatus_IdClienteStatus",
                        column: x => x.IdClienteStatus,
                        principalTable: "ClientesStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaixasPostais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdSocio = table.Column<int>(type: "integer", nullable: false),
                    IdCliente = table.Column<int>(type: "integer", nullable: false),
                    IdStatusCaixa = table.Column<int>(type: "integer", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "text", nullable: true),
                    CpfCnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    DataAluguel = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DiaVencimento = table.Column<int>(type: "integer", nullable: false),
                    ValorMensal = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasPostais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaixasPostais_CaixasStatus_IdStatusCaixa",
                        column: x => x.IdStatusCaixa,
                        principalTable: "CaixasStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasPostais_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixasPostais_Socios_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cobrancas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCaixaPostal = table.Column<int>(type: "integer", nullable: false),
                    IdCobrancaStatus = table.Column<int>(type: "integer", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataLiquidacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobrancas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cobrancas_CaixasPostais_IdCaixaPostal",
                        column: x => x.IdCaixaPostal,
                        principalTable: "CaixasPostais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cobrancas_CobrancasStatus_IdCobrancaStatus",
                        column: x => x.IdCobrancaStatus,
                        principalTable: "CobrancasStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricosPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCobranca = table.Column<int>(type: "integer", nullable: false),
                    IdFormaPagamento = table.Column<int>(type: "integer", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValorPago = table.Column<decimal>(type: "numeric", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricosPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricosPagamento_Cobrancas_IdCobranca",
                        column: x => x.IdCobranca,
                        principalTable: "Cobrancas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricosPagamento_FormasPagamentos_IdFormaPagamento",
                        column: x => x.IdFormaPagamento,
                        principalTable: "FormasPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixasPostais_IdCliente",
                table: "CaixasPostais",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasPostais_IdSocio",
                table: "CaixasPostais",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_CaixasPostais_IdStatusCaixa",
                table: "CaixasPostais",
                column: "IdStatusCaixa");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdClienteStatus",
                table: "Clientes",
                column: "IdClienteStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Cobrancas_IdCaixaPostal",
                table: "Cobrancas",
                column: "IdCaixaPostal");

            migrationBuilder.CreateIndex(
                name: "IX_Cobrancas_IdCobrancaStatus",
                table: "Cobrancas",
                column: "IdCobrancaStatus");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosPagamento_IdCobranca",
                table: "HistoricosPagamento",
                column: "IdCobranca");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosPagamento_IdFormaPagamento",
                table: "HistoricosPagamento",
                column: "IdFormaPagamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricosPagamento");

            migrationBuilder.DropTable(
                name: "Cobrancas");

            migrationBuilder.DropTable(
                name: "FormasPagamentos");

            migrationBuilder.DropTable(
                name: "CaixasPostais");

            migrationBuilder.DropTable(
                name: "CobrancasStatus");

            migrationBuilder.DropTable(
                name: "CaixasStatus");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Socios");

            migrationBuilder.DropTable(
                name: "ClientesStatus");
        }
    }
}
