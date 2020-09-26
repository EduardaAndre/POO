using System;
using System.Globalization;

namespace Exercicio_07_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe a largura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a altura do retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + retangulo.areaRetangulo() + " Perimetro = " + retangulo.perimetroRetangulo() + " Diagonal = " + retangulo.diagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));  

           
        }
    }
}
