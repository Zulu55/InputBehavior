namespace NumberE
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos términos de precisión desea: ");
            var input = Console.ReadLine();
            var numberE = new NumberE();
            Console.WriteLine("e = {0}", numberE.CalculateE(int.Parse(input)));
            Console.ReadKey();
        }
    }
}
