using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // especifica o data source(fonte de dados)
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define a expressão query
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Executa a query
            foreach(int x in result)
                Console.WriteLine(x);
        }
    }
}
