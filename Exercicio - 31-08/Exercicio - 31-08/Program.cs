using System;

namespace Exercicio___31_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos = new Produtos();
            string opcao = "";
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("");
                Console.WriteLine("2 - Adicionar Produto");
                Console.WriteLine("");
                Console.WriteLine("3 - Remover Produto");
                Console.WriteLine("");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Lista de Produto");
                

                opcao = Console.ReadLine();





                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Nome do produto: ");
                        produtos.Nome = Console.ReadLine();
                        Console.WriteLine("Quantidade: ");
                        produtos.Quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Preço: ");
                        produtos.Preco = double.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Quantidade do produto para adicionar: ");
                        produtos.AddProduto(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Nome do produto: " + produtos.Nome + " , R$: " + produtos.Preco + " , quantidade: " + produtos.Quantidade);
                        break;
                    case "3":
                        Console.WriteLine("Quantidade de produto para remover: ");
                        produtos.RemoverProduto(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Nome do produto: " + produtos.Nome + " , R$: " + produtos.Preco + " , quantidade: " + produtos.Quantidade);
                        break;
                }
            
            }
            while (opcao != "5");
            {
                Console.ReadLine(); 
            }
        }
        }
    }

