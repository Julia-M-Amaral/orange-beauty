using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orange_Beauty.Migrations
{
    /// <inheritdoc />
    public partial class createfuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFunc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFFunc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DNFunc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogradouroFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplementoFunc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEPFunc = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CidadeFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NivelAcesso = table.Column<int>(type: "int", nullable: false),
                    DtCadastroFunc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
