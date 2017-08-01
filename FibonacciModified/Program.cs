namespace FibonacciModified
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos términos desea: ");
            var input = Console.ReadLine();
            var fibonacciModified = new FibonacciModified();
            fibonacciModified.GetNumbers(int.Parse(input));
            Console.WriteLine(fibonacciModified.Serie);
            Console.WriteLine("La suma es: {0}", fibonacciModified.Sum);
            Console.ReadKey();
        }
    }
}
