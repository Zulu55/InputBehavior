namespace FibonacciModified
{
    public class FibonacciModified
    {
        public string Serie { get; set; }
        public double Sum { get; set; }

        public void GetNumbers(int n)
        {
            int a = 0;
            Serie = "0";
            Sum = 0;

            if (n == 1) return;

            int b = 1;
            Serie = "0, 1";
            Sum = 1;

            if (n == 2) return;

            int c = 2;
            Serie = "0, 1, 2";
            Sum = 3;

            if (n == 3) return;

            Serie += ", ";
            int i = 3;
            while (i < n)
            {
                int d = a + b + c;
                Serie += string.Format("{0}, ", d);
                Sum += d;
                a = b;
                b = c;
                c = d;
                i++;
            }

            Serie = Serie.Substring(0, Serie.Length - 2);
        }
    }
}
