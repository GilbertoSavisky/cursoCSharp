using System.Collections.Generic;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Notebook", 1200.00));
            list.Add(new Produto("Tablet", 450.00));

            list.Sort(ComparaProdutos);

            foreach(Produto p in list)
                Console.WriteLine(p);
        }

        static int ComparaProdutos(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}
