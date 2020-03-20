using System;


namespace bai2
{
    class Program
    {
        static void nhapX(out double x) {
            do
            {
                Console.WriteLine("nhap x: ");
                x = double.Parse(Console.ReadLine());
            }
            while (x < 0);
        }
        static void nhapA(out float a)
        {
            Console.WriteLine("nhap a: ");
            a = float.Parse(Console.ReadLine());
        }
        static void nhapN(out int n)
        {
            do
            {
                Console.WriteLine("nhap n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 5 || n > 20);

        }
        static double squareRoot(double x,int k)
        {
            return Math.Sqrt(Math.Pow(x, k));

        }
        static double resultS(float a, double x, int n)
        {
            double s = a;
            int k = 1;
            for(int i = n; i > 0; i--)
            {
                s +=Math.Pow(-1,n)* squareRoot(x, k++) / i;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            float a;
            double x;
            nhapA(out a);
            nhapN(out n);
            nhapX(out x);
            Console.WriteLine("S= "+resultS(a, x, n));
            Console.ReadKey();

            
        }
    }
}
