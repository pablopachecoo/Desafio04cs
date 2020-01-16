using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Desafio04.br.com.gft.model;

namespace Desafio04.br.com.gft.main
{
    public class main
    {
        public static void Main(String[] args)
        {
//Criando Livros
        Livro l1 = new Livro("Harry Potter", 40, 5, "J. K. Rowling", "fantasia", 300);
		Livro l2 = new Livro("O Senhor dos Aneis", 30, 3, "Tolkien", "Fantasia", 500);
		Livro l3 = new Livro("Java POO", 20, 30, "GFT", "educativo", 500);
		
// Criando VideoGames \\
		VideoGame ps4 = new VideoGame("ps4", 1800, 100, "Sony", "Slim", false);
		VideoGame ps4Usado = new VideoGame("ps4usado", 1000, 7, "Sony", "Slim", true);
		VideoGame xbox = new VideoGame("Xbox", 1500, 500, "Microsoft", "One", false);
			
// Adicionando os Livros ao Array \\
			List<Livro> Livro = new List<Livro>
			{
			l1,
			l2,
			l3
			};
// Adicioando os Livros ao Array \\
			List<VideoGame> VideoGame = new List<VideoGame>
			{
			ps4,
			ps4Usado,
			xbox
			};

// Criando a Loja
			Loja americanas = new Loja("Americanas", "12345678", Livro, VideoGame);


			l1.calculaImposto();
			l2.calculaImposto();
			l3.calculaImposto();

			ps4Usado.calculaImposto();
			ps4.calculaImposto();

			americanas.listaLivros();
			americanas.listaVideoGames();
			americanas.calculaPatrimonio();
			Console.ReadLine();


		}
				
		
    }
}
