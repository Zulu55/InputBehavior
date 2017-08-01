namespace Taylor
{
    using System;

    public class Taylor
    {
        private double x;

        public Taylor(double x)
        {
            this.x = x;
        }

        private double Factorial(int n)
        {
            double aux = 1;
            for (int i = 2; i <= n; i++)
            {
                aux *= i;
            }

            return aux;
        }

        public double Calculate(int n)
        {
            double aux = 0;
            for (int i = 0; i < n; i++)
            {
                aux += Math.Pow(x, i) / Factorial(i);
            }

            return aux;
        }
    }
}
