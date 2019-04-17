namespace System
{
    class Program
    {
        //BinaryNumericOperation
        delegate void OperacaoBinariaNumerica(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            OperacaoBinariaNumerica op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a,b);
            
        }
    }
}
