using System;

namespace Bai3
{
    class Program
    {
        static string[] a;
        static void Nhap(String s)
        {
            a = s.Split(' ');
            Console.Write("(arr={");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < (a.Length - 1))
                {
                    Console.Write(',');
                }
            }
            Console.Write("})");
        }
        static void Show()
        {
            Console.WriteLine("\nHo: " + a[0]);
            Console.WriteLine("Ten dem: " + a[1]);
            Console.WriteLine("Ten: " + a[2]);
            Console.WriteLine("nam sinh: " + a[3]);
        }
        static int Age()
        {
            return 2020 - int.Parse(a[a.Length - 1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi gom ho ten nam sinh");
            string s = Console.ReadLine();
            Nhap(s);
            Show();


            Console.ReadKey();

        }
    }
}
