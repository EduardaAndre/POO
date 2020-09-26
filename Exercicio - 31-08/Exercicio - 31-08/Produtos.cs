using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio___31_08
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade; 


        public double valorTotalEstoque()
        {
            double Total = Quantidade * Preco;
            return Total; 
        }

        public void AddProduto(int qtd)
        {
            Quantidade = Quantidade + qtd; 

        }

        public void RemoverProduto(int qtd)
        {
            Quantidade = Quantidade - qtd; 
        }

        
    }
}
