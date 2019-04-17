using System;
using System.Collections.Generic;
using System.IO;
using InterfaceIComparable.Entities;
using System.Threading.Tasks;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\dev\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Funcionario str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
