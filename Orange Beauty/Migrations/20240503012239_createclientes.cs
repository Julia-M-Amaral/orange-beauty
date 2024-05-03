using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orange_Beauty.Migrations
{
    /// <inheritdoc />
    public partial class createclientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCli = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailCli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoneCli = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CPFCli = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    LogradouroFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplementoFunc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEPFunc = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CidadeFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoFunc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DtCadastroFunc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
