using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 3 số a, b, c (là các số thực không âm). 
            //Kiểm tra xem đó có phải là 3 cạnh của tam giác không?
            //Nếu có thì nó thuộc loại tam giác gì(thường, cân, vuông, vuông cân hay đều). 
            float a, b, c;
            do
            {
                Console.WriteLine("nhap ba canh tam giac a, b, c: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            } while (a < 0 || b < 0 || c < 0);
            if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b + c > a)
            {
                if(a==b && a==c && b == c)
                {
                    Console.Write("tam giac tren la tam giac deu");
                }
                else if (a == b||b==c||a==c) {
                    Console.Write("tam giac tren la tam giac can");

                }
                else if(a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.Write("Tam giac vuong can");
                    }
                    else
                    {
                        Console.Write("Tam giac vuong");
                    }
                }
                else
                {
                    Console.Write("tam giac thuong");
                }

            }
            else
            {
                Console.Write("khong thoa man ");
            }
            Console.ReadKey();
        }
    }
}
