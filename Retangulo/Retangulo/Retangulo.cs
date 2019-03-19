using System;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public double Largura, Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double Diagonal()
        {
            double x = (Altura * Altura) + (Largura * Largura);

            return Math.Sqrt(x);
        }
    }
}
