using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AluguelWeb.Migrations
{
    public partial class aluguelLivros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo_aluguel");

            migrationBuilder.CreateTable(
                name: "autor",
                schema: "dbo_aluguel",
                columns: table => new
                {
                    cd_autor = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_autor = table.Column<string>(nullable: true),
                    cpf_autor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.cd_autor);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                schema: "dbo_aluguel",
                columns: table => new
                {
                    cd_cliente = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_cliente = table.Column<string>(nullable: true),
                    cpf_cliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.cd_cliente);
                });

            migrationBuilder.CreateTable(
                name: "editora",
                schema: "dbo_aluguel",
                columns: table => new
                {
                    cd_editora = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_editora = table.Column<string>(nullable: true),
                    cnpj_editora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editora", x => x.cd_editora);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                schema: "dbo_aluguel",
                columns: table => new
                {
                    cd_livro = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_livro = table.Column<string>(nullable: true),
                    cd_autor = table.Column<int>(nullable: false),
                    cd_editora = table.Column<int>(nullable: false),
                    st_livro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.cd_livro);
                    table.ForeignKey(
                        name: "FK_livro_autor_cd_autor",
                        column: x => x.cd_autor,
                        principalSchema: "dbo_aluguel",
                        principalTable: "autor",
                        principalColumn: "cd_autor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_livro_editora_cd_editora",
                        column: x => x.cd_editora,
                        principalSchema: "dbo_aluguel",
                        principalTable: "editora",
                        principalColumn: "cd_editora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emprestimo",
                schema: "dbo_aluguel",
                columns: table => new
                {
                    cd_emprestimo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    cd_livro = table.Column<int>(nullable: false),
                    cd_cliente = table.Column<int>(nullable: false),
                    dt_emrpestimo = table.Column<DateTime>(nullable: false),
                    pv_devolucao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimo", x => x.cd_emprestimo);
                    table.ForeignKey(
                        name: "FK_emprestimo_cliente_cd_cliente",
                        column: x => x.cd_cliente,
                        principalSchema: "dbo_aluguel",
                        principalTable: "cliente",
                        principalColumn: "cd_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emprestimo_livro_cd_livro",
                        column: x => x.cd_livro,
                        principalSchema: "dbo_aluguel",
                        principalTable: "livro",
                        principalColumn: "cd_livro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_cd_cliente",
                schema: "dbo_aluguel",
                table: "emprestimo",
                column: "cd_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_cd_livro",
                schema: "dbo_aluguel",
                table: "emprestimo",
                column: "cd_livro");

            migrationBuilder.CreateIndex(
                name: "IX_livro_cd_autor",
                schema: "dbo_aluguel",
                table: "livro",
                column: "cd_autor");

            migrationBuilder.CreateIndex(
                name: "IX_livro_cd_editora",
                schema: "dbo_aluguel",
                table: "livro",
                column: "cd_editora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprestimo",
                schema: "dbo_aluguel");

            migrationBuilder.DropTable(
                name: "cliente",
                schema: "dbo_aluguel");

            migrationBuilder.DropTable(
                name: "livro",
                schema: "dbo_aluguel");

            migrationBuilder.DropTable(
                name: "autor",
                schema: "dbo_aluguel");

            migrationBuilder.DropTable(
                name: "editora",
                schema: "dbo_aluguel");
        }
    }
}
