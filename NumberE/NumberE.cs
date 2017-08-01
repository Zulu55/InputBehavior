namespace NumberE
{
    public class NumberE
    {
        private double Factorial(int n)
        {
            double aux = 1;
            for (int i = 2; i <= n; i++)
            {
                aux *= i;
            }

            return aux;
        }
        
        public double CalculateE(int n)
        {
            double sum = 0;
            int i = 0;
            while (i < n)
            {
                var f = Factorial(i);
                sum += 1 / f;
                i++;
            }

            return sum;
        }
    }
}
