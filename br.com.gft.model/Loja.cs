using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.br.com.gft.model
{
    public class Loja
    {
		string Nome {get; set;}
        string cnpj {get; set;}
        List<Livro> livros {get; set;}
        List<VideoGame> VideoGames {get; set;}


        public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> videoGames) 
        {
		Nome = nome;
		this.cnpj = cnpj;
		this.livros = livros;
		VideoGames = videoGames;
        }

		public void listaLivros()
		{		if (livros.Count > 0)
			{
				Console.WriteLine(" ¦¦¦¦¦¦¦¦¦¦¦¦ Atualmente temos " + livros.Count + " Livros na Loja ¦¦¦¦¦¦¦¦");
			}
			else
			{
				Console.WriteLine("A Loja não tem Livros no seu Estoque");
			}

			Console.WriteLine(" ¦_____________________________________________________¦");
		for (int i = 0; i < livros.Count; i++)
			{
			Console.WriteLine(" Título: " + livros[i].Nome +  ", " + "Preço: " + livros[i].Preco + " " + "Quantidade: " + livros[i].Qnt + ", " + "Em Estoque");
			}
		}


		public void listaVideoGames()
		{
			// Mensagem com o Número de VideoGames
			Console.WriteLine(" ____________________________________________________" + "\n" + "      Atualmente temos " + VideoGames.Count + " Videogames No estoque");

			if (VideoGames.Count > 0)
			{
				for (int i = 0; i < VideoGames.Count; i++)
				{
					Console.WriteLine(" Nome: " + VideoGames[i].Nome + ", " + "Preço: "
							+ VideoGames[i].Preco + ", " + "Quantidade: " + VideoGames[i].Qnt + " Em Estoque");

				}
			}

		}

		public double calculaPatrimonio()
		{
			Console.WriteLine(" ____________________________________________________");

			double patrimonio = 0;
			for (int i = 0; i < livros.Count; i++)
			{
				patrimonio += livros[i].Preco * livros[i].Qnt;
			}

			for (int i = 0; i < VideoGames.Count; i++)
			{
				patrimonio += VideoGames[i].Preco * VideoGames[i].Qnt;

			}
			// OUTPUT DO PATRIMONIO \\
			Console.WriteLine("      O patrimonio da loja " + Nome + "é de " + patrimonio);
			return patrimonio;
					   
		}



	}
	

    
}
