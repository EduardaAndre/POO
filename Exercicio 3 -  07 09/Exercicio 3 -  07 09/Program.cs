using System;

namespace Exercicio_3____07_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Escreva o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("1º NOTA - Pontuação máxima: 30. \n2º NOTA - Pontuação máxima: 35. \n3º NOTA- Pontuação máxima: 35");
            
            do
            {
                Console.WriteLine("Informe a primeira nota: ");
                aluno.nota1 = double.Parse(Console.ReadLine());

            }
            while (aluno.nota1 < 0 || aluno.nota1 > 30);
            do

            {
                Console.WriteLine("Informe a segunda nota: ");
                aluno.nota2 = double.Parse(Console.ReadLine());

            }
            while (aluno.nota2 < 0 || aluno.nota2 > 35);
            do

            {
                Console.WriteLine("Inforome a terceira nota: ");
                aluno.nota3 = double.Parse(Console.ReadLine());

            }
            while (aluno.nota3 < 0 || aluno.nota3 > 35);

            if (aluno.SomaNota() >= 60)
            {
                Console.WriteLine("Aluno aprovado. \nPontuação do aluno: " + aluno.SomaNota() + " pontos."); 

            }
            else
            {
                Console.WriteLine("Aluno Reprovado. \nFaltaram " + (100 - aluno.SomaNota()) + " pontos"); 
            }
        }
    }
}
