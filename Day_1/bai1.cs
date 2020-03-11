using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("nhap 5 so a, b, c, d, e: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("gia tri vua nhap: " + a +" " +b +" "+ c +" "+ d +" "+ e);

          //  bat dau tim max1
            int max1 = a;
            if (max1 < b) max1 = b;
            if (max1 < c) max1 = c;
            if (max1 < d) max1 = d;
            if (max1 < e) max1 = e;
           // gan gia tri cho max2
            int max2 = a;
            //if (max2 != a) max2 = a;
            //if (max2 != b) max2 = b;
            //if (max2 != c) max2 = c;
            //if (max2 != d) max2 = d;
            //if (max2 != e) max2 = e;

          //  bat dau tim max2
            if (max1 != a) if (max2 < a) max2 = a;
            if (max1 > b) if (max2 < b) max2 = b;
            if (max1 > c) if (max2 < c) max2 = c;
            if (max1 > d) if (max2 < d) max2 = d;
            if (max1 > e) if (max2 < e) max2 = e;
            Console.WriteLine("so lon thu 2: " + max2);


            Console.ReadKey();
        }
    }
}
