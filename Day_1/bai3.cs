using System;

namespace bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 3: Nhập vào 1 số nguyên n.Hiển thị các ước của nó ra màn hình
            //    (khi  n chia hết cho m thì m đc gọi là ước của n)
            int n;
            Console.WriteLine("nhap n; ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine("cac so n chia het " + i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
