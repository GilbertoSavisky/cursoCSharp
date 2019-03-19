using System;
using System.Collections.Generic;
using System.Globalization;

namespace FuncionariosSalarios
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void IncrementarSalario(Funcionario funcionario, double porcentagem)
        { 
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Salário: {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
