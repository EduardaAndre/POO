using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Exercicio2_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Nome do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = f1.Salario + f2.Salario / 2;
            Console.WriteLine("A média salarial é: " + media); 
            
           

            
        }
    }
}
