using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2__07_08
{
    class Funcionario
    {
        public String Nome;
        public double SalarioB;
        public double Imposto; 

        public double SalarioL()
        {
            double SL = SalarioB - Imposto;
            return SL; 
        }
        public void AumentoSalario(double AttSal)
        {
            SalarioB = SalarioL() + (SalarioB * (AttSal / 100)); 
        }
    }
}
