using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orange_Beauty.Migrations
{
    /// <inheritdoc />
    public partial class createprodutoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    PrecoProd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescricaoProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstoqueProd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
