using System.Collections.Generic;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            list.Add(new Produto("Tv", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.50));
            list.Add(new Produto("HD Case", 80.90));

            /*Função Lambda
            list.RemoveAll(p => p.Preco >= 100.0);*/

            list.RemoveAll(TestaProduto);
            foreach (Produto p in list)
                Console.WriteLine(p);
        }

        public static bool TestaProduto(Produto p)
        {
            return p.Preco >= 100.0;
        }
    }
}
