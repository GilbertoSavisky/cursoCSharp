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

            var r1 = produtos.Where(p => p.Categoria.Categorias == 1 && p.Preco < 900);
            Print("Categoria 1 e preco < 900: ", r1);

            var r2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome);
            Print("Nomes de produtos da Cat ferramentas", r2);

            var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CatNome = p.Categoria.Nome});
            Print("Nomes começados com 'C' e obj anonimos", r3);

            var r4 = produtos.Where(p => p.Categoria.Categorias == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            Print("Cat 1 order by preço then nome", r4);

            var r5 = r4.Skip(2).Take(4); // skipe(pula) 2 e take(pega) 4 elementos
            Print("Cat 1 order by preço then nome skipe 2 e take 4", r5);

            var r6 = produtos.First();
            Console.WriteLine("Primeiro elemento: \n\t"+r6);

            var r7 = produtos.Where(p => p.Preco > 3000).FirstOrDefault();
            Console.WriteLine("Primeiro elemento ou default: \n\t" + r7);

            Console.WriteLine();

            var r8 = produtos.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default: \n\t"+ r8);
            var r9 = produtos.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default: \n\t" + r9);

            var r10 = produtos.Max(p => p.Preco);
            Console.WriteLine("Preço maximo: "+r10);
            var r11 = produtos.Min(p => p.Preco);
            Console.WriteLine("Preço minimo: " + r11);

            var r12 = produtos.Where(p => p.Categoria.Id == 1).Sum(p => p.Preco);
            Console.WriteLine("Cat 1 com soma dos preços: "+r12);
            var r13 = produtos.Where(p => p.Categoria.Id == 1).Average(p => p.Preco);
            Console.WriteLine("Cat 1 com média dos preços: " + r13);

            var r14 = produtos.Where(p => p.Categoria.Id == 5).Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Cat 5 com média dos preços: " + r14);

            var r15 = produtos.Where(p => p.Categoria.Id == 1).Select(p => p.Preco).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Cat 1 aggregate soma :"+r15);

            Console.WriteLine();
            var r16 = produtos.GroupBy(p => p.Categoria);
            foreach(IGrouping<Categoria, Produto> group in r16)
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
