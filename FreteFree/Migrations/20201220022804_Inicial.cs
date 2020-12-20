using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreteFree.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeResponsavel = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneEmpresa = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeEmpresa = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastroEmpresa = table.Column<DateTime>(nullable: false),
                    EmpresaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_Empresa_Empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    MotoristaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCadastoMotorista = table.Column<DateTime>(nullable: false),
                    CaminhaoProprietario = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EnderecoProprietario = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneProprietario = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    TipoCaminhao = table.Column<int>(nullable: false),
                    PlacaCavalo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeCavalo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EstadoCavalo = table.Column<int>(nullable: false),
                    PlacaCarreta = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeCarreta = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EstadoCarreta = table.Column<int>(nullable: false),
                    NomeMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EnderecoMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneMovel = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    TelefoneFixo = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    CidadeMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EstadoMotorista = table.Column<int>(nullable: false),
                    CPFMotorista = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    RGMotorista = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    CNPJ = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    MotoristaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.MotoristaId);
                    table.ForeignKey(
                        name: "FK_Motorista_Motorista_MotoristaId1",
                        column: x => x.MotoristaId1,
                        principalTable: "Motorista",
                        principalColumn: "MotoristaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdemCarregamento",
                columns: table => new
                {
                    OrdemCarregamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(nullable: false),
                    MotoristaId = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    Medida = table.Column<int>(nullable: false),
                    DataOrdemCarregamento = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemCarregamento", x => x.OrdemCarregamentoId);
                    table.ForeignKey(
                        name: "FK_OrdemCarregamento_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemCarregamento_Motorista_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motorista",
                        principalColumn: "MotoristaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmpresaId1",
                table: "Empresa",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Motorista_MotoristaId1",
                table: "Motorista",
                column: "MotoristaId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemCarregamento_EmpresaId",
                table: "OrdemCarregamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemCarregamento_MotoristaId",
                table: "OrdemCarregamento",
                column: "MotoristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdemCarregamento");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Motorista");
        }
    }
}
