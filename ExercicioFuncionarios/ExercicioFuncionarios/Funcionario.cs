using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return ($"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void AumentarSalario(double porcento)
        {
            SalarioBruto +=( SalarioBruto *= (porcento/100));
        }
    }
}
