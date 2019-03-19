using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            System.Console.WriteLine("Entre com as medidas do triângulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine("Área de x = "+ areaX.ToString("F4", CultureInfo.InstalledUICulture));
            System.Console.WriteLine("Área de y = "+ areaY.ToString("F4", CultureInfo.InstalledUICulture));

            if (areaX > areaY)
            {
                System.Console.WriteLine("Maior área: X");
            }
            else
            {
                System.Console.WriteLine("Maior área: Y");
            }
        }
    }
}
