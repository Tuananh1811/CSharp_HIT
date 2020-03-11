using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 5: Viết chương trình nhập vào 1 số nguyên n.
            //    Kiểm tra xem n có phải là số nguyên tố hay không ?
            int n,dem=0;
            Console.WriteLine("nhap n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("n ko la so nguyen to");
            }
            else
            {
               for(int i=2;i< Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        dem++;

                    }
                }
                if (dem == 0)
                {
                    Console.WriteLine("n la so nguyen to");

                }
                else
                {
                    Console.WriteLine("n khong la so nguyen to");
                }
            }
            Console.ReadKey();
        }
    }
}
