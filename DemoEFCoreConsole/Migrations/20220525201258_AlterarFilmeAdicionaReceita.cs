using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEFCoreConsole.Migrations
{
    public partial class AlterarFilmeAdicionaReceita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Receita",
                table: "Filmes",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receita",
                table: "Filmes");
        }
    }
}
