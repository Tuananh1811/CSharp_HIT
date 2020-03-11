using System;

namespace bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 6 *: Nhập vào 1 số nguyên n, phân tích số đó thành tích của các thừa số nguyên tố. 
            //VD: 28 = 2 x 2 x 7

            int n;
            Console.WriteLine("nhap n: ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if (n % j == 0)
                    {
                        n /= j;
                        if (n == 1)
                        {
                            Console.Write(j);
                        }
                        else
                        {
                            Console.Write(j+ "*" );
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
