using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.br.com.gft.model
{
    public class VideoGame : Produto
    {
        string Marca;
        string Modelo;
        bool isUsado;

        public VideoGame(string nome, double preco, int qnt, string marca, string modelo, bool isUsado) : base(nome, preco, qnt)
        {

            Marca = marca;
            Modelo = modelo;
            this.isUsado = isUsado;
        }

        public double calculaImposto() {        
		double valor = 0;
		if (isUsado = true && Nome == "ps4usado") {
			valor = Preco * 0.25;
			Console.WriteLine("O valor do imposto no " + Nome + " é de " + valor + " Reais");
		} else {
			valor = Preco * 0.45;
			Console.WriteLine("O valor do imposto no " + Nome + " é de " + valor + " Reais" + "\n" + "  _____________________________________________________");
		}
		return valor;

			
		}
    }
}
