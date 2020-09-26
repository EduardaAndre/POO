using System;
using System.Globalization;

namespace Exercicio_ToString_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do produto.");
            
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
           
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade); // Instância o produto

            Console.WriteLine("Dados do produto " + produto);

            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.Add(qte); // Chamou o método ADD() 

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.Remover(qte); // Chamou o método Remover()

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
