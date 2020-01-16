using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio04.br.com.gft.model
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qnt { get; set; }

        // construtor
        public Produto(string nome, double preco, int qnt)
        {            
            Nome = nome;
            Preco = preco;
            Qnt = qnt;
        }

    }


}
