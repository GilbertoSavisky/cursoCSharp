using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMatriz
{
    class Matriz
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }
        public int[,] Dados { get; set; }


        public void AnalisaPosicoes(int num, int[] dados)
        {
            string pos = "";
            for (int i = 0; i < Linha; i++)
            {
                if (dados[i] == num)
                    pos = i.ToString();
                for (int j = 0; j < Coluna; j++)
                {
                    if (dados[j] == num)
                        pos += "," + j.ToString();
                }
            }
            Console.WriteLine(pos);
        }

    }
}
