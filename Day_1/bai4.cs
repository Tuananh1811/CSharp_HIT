using System;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 4: Nhập vào số tự nhiên n. Tính S1, S2, S3 rồi in kết quả ra màn hình, biết rằng:
            //S1 = 1 + 2 + 3 + ..+n
            //S2 = 1 * 2 * 3 * ...*n
            //S3 = 1 * 2 + 2 * 3 + 3 * 4 + ..+(n - 1) * n
            int n, S1=0, S2=1 , S3=1;
            Console.WriteLine("nhap n: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                S1 += i;
                S2 *= i;
                S3 += (i - 1) * i;
            }
            Console.WriteLine("S1= " + S1 + " " + " S2= " + S2 + " " + " S3= " + S3);
            Console.ReadKey();


        }
    }
}
