using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Dire Straits", "Melhor banda de todos os tempos", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTW39WL1579kLZChcd15J9qQ4em_-U6pZ7Ev166z_qVLQ&s" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Men I trust", "Batidas suaves", "https://f4.bcbits.com/img/a0847169226_2.jpg" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Boogarins", "Psicodelia maluca", "https://www.otempo.com.br/image/contentid/policy:1.3317628:1706110486/BOOGARINS-12-PH-Pedro-Margueritho-png.png?f=3x2&w=1224" });

            migrationBuilder.InsertData("musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Calling Elvis", 1, 1999 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ARTISTAS");
        }
    }
}
