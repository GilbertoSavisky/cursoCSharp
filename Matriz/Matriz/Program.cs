using System;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = 0;
            int coluna = 0;
            string valorLinha = "";
            string valorColuna = "";
            Console.WriteLine("Digitar somente números!!!");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("Entre com a quantidade de linhas e colunas!");
            Console.Write("Linha: ");
            valorLinha = Console.ReadLine();
            Console.Write("Coluna: ");
            valorColuna = Console.ReadLine();
            while (!int.TryParse(valorLinha, out linha) || (!int.TryParse(valorColuna, out coluna)))
            {
                Console.WriteLine("Favor digitar somente número inteiro!");
                Console.Write("\tLinha: ");
                valorLinha = Console.ReadLine();
           
                Console.WriteLine("Favor digitar somente número inteiro!");
                Console.Write("\tColuna: ");
                valorColuna = Console.ReadLine();
            }

            int[,] matriz = new int[linha, coluna];


            Console.WriteLine("______________________________________________");
            for (int i = 0; i < linha; i++)
            {
                Console.Write($"Digite os 0{coluna} números da linha {i}: ");
                string[] numeros = Console.ReadLine().Split(' ');
                
                while(numeros.Length != coluna)
                {
                    Console.Clear();
                    Console.Write($"Digite os 0{coluna} números da linha {i}: ");
                    numeros = Console.ReadLine().Split(' ');
                }
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }


            Console.WriteLine("______________________________________________");
            Console.Write("Digite um número da matriz a ser pesquisado: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("______________________________________________");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.WriteLine("Posição (" + i.ToString() + "," + j.ToString() + "):");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }

                        if (j < coluna - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }

                        if (i < linha - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                        Console.WriteLine("______________________________________________");
                    }
                }

            }
        }

    }
}
