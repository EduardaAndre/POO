using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_ToString_
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) // Construtor. 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEstoque() // Calculo do valor de estoque
        {
            return Preco * Quantidade;
        }

        public void Add(int quantidade) // adicionou peças 
        {
            Quantidade += quantidade;
        }

        public void Remover(int quantidade) // Removeu peças
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() // Método ToString para impressão de informações.
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
