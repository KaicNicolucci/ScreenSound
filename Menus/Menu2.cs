using Modelos;

namespace Menus;

internal class Menu2 : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("O álbum pertence a banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write("Agora, informe o nome do álbum: ");
            string nomeAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeBanda];
            banda.AdicionarAlbum(new Album(nomeAlbum));

            Console.WriteLine($"\nO álbum {nomeAlbum} de {nomeBanda} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada em nosso banco de dados.");
            Console.WriteLine("Digite alguma tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}