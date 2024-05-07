using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class NovasMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Calling Elvis", 1, 1999 });
            migrationBuilder.InsertData("musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Billie Toppy", 2, 2022 });
            migrationBuilder.InsertData("musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Onda Negra", 3, 2017 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ARTISTAS");
        }
    }
}
