using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercicio_3____07_09
{
    class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double SomaNota()
        {
            double soma = nota1 + nota2 + nota3;
            return soma; 
        }
    }
}
