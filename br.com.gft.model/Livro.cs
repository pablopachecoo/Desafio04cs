using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.br.com.gft.model
{
    public class Livro : Produto
    {
        public string Autor {get; set;}
        public string Tema {get; set;}
        public int qntPag {get; set;}
        
        public Livro(string nome, double preco, int qnt, string autor, string tema, int qntPag) : base(nome, preco, qnt)
        {
		Autor = autor;
		Tema = tema;
		this.qntPag = qntPag;
	    }

        public double calculaImposto() {
		double valor = 0;
		if (Tema == "educativo") {
			Console.WriteLine("O livro (" + Nome +  ") Não tem imposto, " + " Tema: " + Tema);
			return 0;
		} else {
			valor = Preco * 0.10;
			Console.WriteLine("O valor do imposto sobre o livro (" + Nome +  ") é de  " + valor + " Reais");
			return valor;

		}

	}

    }




}
