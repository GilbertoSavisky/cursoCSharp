using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
                Console.WriteLine(obj);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Categorias = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Categorias = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", Categorias = 1 };


            List<Produto> produtos = new List<Produto>()
            {
                new Produto() {Id= 1, Nome = "Computador", Preco = 1100.0, Categoria = c2},
                new Produto() {Id= 2, Nome = "Martelo", Preco = 90.0, Categoria = c1},
                new Produto() {Id= 3, Nome = "Tv", Preco = 1700.0, Categoria = c3},
                new Produto() {Id= 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2},
                new Produto() {Id= 5, Nome = "Serrote", Preco = 80.0, Categoria = c1},
                new Produto() {Id= 6, Nome = "Tablet", Preco = 700.0, Categoria = c2},
                new Produto() {Id= 7, Nome = "Camera", Preco = 700.0, Categoria = c3},
                new Produto() {Id= 8, Nome = "Impressora", Preco = 350.0, Categoria = c3},
                new Produto() {Id= 9, Nome = "MacBook", Preco = 1800.0, Categoria = c2},
                new Produto() {Id= 10, Nome = "Soud Bar", Preco = 700.0, Categoria = c3},
                new Produto() {Id= 11, Nome = "Nivel", Preco = 70.0, Categoria = c1}
            };

            //var r1 = produtos.Where(p => p.Categoria.Categorias == 1 && p.Preco < 900);
            var r1 = from p in produtos where p.Categoria.Categorias == 1 && p.Preco < 900 select p;
            Print("Categoria 1 e preco < 900: ", r1);

            //var r2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome);
            var r2 = from p in produtos where p.Categoria.Nome == "Ferramentas" select p.Nome;
            Print("Nomes de produtos da Cat ferramentas", r2);

            //var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CatNome = p.Categoria.Nome});
            var r3 = from p in produtos where p.Nome[0] == 'C' select new { p.Nome, p.Preco, CatName = p.Categoria.Nome };
            Print("Nomes começados com 'C' e obj anonimos", r3);

            //var r4 = produtos.Where(p => p.Categoria.Categorias == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            var r4 = from p in produtos where p.Categoria.Categorias == 1 orderby p.Nome orderby p.Preco select p;
            Print("Cat 1 order by preço then nome", r4);

            //var r5 = r4.Skip(2).Take(4); // skipe(pula) 2 e take(pega) 4 elementos
            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("Cat 1 order by preço then nome skipe 2 e take 4", r5);

            Console.WriteLine();


            //var r16 = produtos.GroupBy(p => p.Categoria);
            var r16 = from p in produtos group p by p.Categoria;
            foreach (IGrouping<Categoria, Produto> group in r16)
            {
                Console.WriteLine("Cat "+ group.Key.Nome+":");
                foreach(Produto p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
