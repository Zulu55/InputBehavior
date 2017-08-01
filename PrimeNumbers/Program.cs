namespace PrimeNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos primos desea: ");
            var input = Console.ReadLine();
            var primes = new Primes();
            primes.GetPrimes(int.Parse(input));
            Console.WriteLine(primes.ThePrimes);
            Console.WriteLine("La suma es: {0}", primes.Sum);
            Console.WriteLine("El promedio es: {0}", primes.Average);
            Console.ReadKey();
        }
    }
}
