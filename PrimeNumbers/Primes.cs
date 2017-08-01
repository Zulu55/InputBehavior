namespace PrimeNumbers
{
    using System;

    public class Primes
    {
        public double Sum { get; set; }
        public double Average { get; set; }
        public string ThePrimes { get; set; }

        private bool IsPrime(int n)
        {
            int m = (int)Math.Sqrt(n);
            int i = 2;
            while (i <= m)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public void GetPrimes(int n)
        {
            Sum = 0;
            ThePrimes = string.Empty;

            int conPri = 0;
            int i = 1;
            while (conPri < n)
            {
                if (IsPrime(i))
                {
                    ThePrimes += string.Format("{0}, ", i);
                    Sum += i;
                    conPri++;
                }

                i++;
            }

            ThePrimes = ThePrimes.Substring(0, ThePrimes.Length - 2);
            Average = (double)(Sum / n);
        }
    }
}
