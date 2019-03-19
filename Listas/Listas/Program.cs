using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Ana");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(2, "José");

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------------------------");


            Console.WriteLine("List count: "+list.Count);

            string s1 = list.Find(x => x[0] == 'B');
            Console.WriteLine("Primeiro com 'B': "+s1);

            s1 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último com 'A': " + s1);
            Console.WriteLine("-----------------------------------");
            int pos = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First posição 'A': "+pos );

            


            pos = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last posição 'A': " + pos);

            List<string> list2 = list.FindAll(x => x.Length == 4);
            Console.WriteLine("-----------------------------------");
            foreach(string s in list2)
            {
                Console.WriteLine("Nomes tamanho 4: "+s);
            }

            list.Remove("José");
            Console.WriteLine("-----------------------------------");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }


            list.RemoveAll(x => x[0] == 'B');
            Console.WriteLine("-----------------------------------");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
