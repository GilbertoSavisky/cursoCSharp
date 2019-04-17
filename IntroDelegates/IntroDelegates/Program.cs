namespace System
{
    class Program
    {
        //BinaryNumericOperation
        delegate double OperacaoBinariaNumerica(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            OperacaoBinariaNumerica op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
