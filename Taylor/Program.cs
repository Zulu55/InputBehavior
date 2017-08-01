namespace Taylor
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos términos desea: ");
            var inputN = Console.ReadLine();
            Console.Write("Digita el valor de X: ");
            var inputX = Console.ReadLine();
            var taylor = new Taylor(double.Parse(inputX));
            Console.WriteLine("f(x) = {0}", taylor.Calculate(int.Parse(inputN)));
            Console.ReadKey();
        }
    }
}