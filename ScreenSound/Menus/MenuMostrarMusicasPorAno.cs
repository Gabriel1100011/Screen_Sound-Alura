using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicasPorAno : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Mostrar músicas por ano de lançamento");
            Console.WriteLine("Digite o ano para consultar músicas:");

            string anoLancamento = Console.ReadLine();
            var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
            var listaAnoLancamento = musicaDAL.ListarPor(a => a.AnoLancamento == Convert.ToInt32(anoLancamento));

            if (anoLancamento.Any() )
            {
                Console.WriteLine($"\nMusicas do ano {anoLancamento}:");
                foreach(var musica in listaAnoLancamento)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }else
            {
                Console.WriteLine($"O ano {anoLancamento} não foi encontrado");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
