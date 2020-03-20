using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài 1: Viết chương trình gồm:  
//o hàm nhập vào một số nguyên dương n.
//o hàm nhập vào một mảng số nguyên với n phần tử o hàm kiểm tra số nguyên tố
//o   hàm xuất ra các phần tử ở vị trí x(với x là số nguyên tố)
//Hàm main nhập vào 1 số nguyên dương n, nhập vào một mảng số nguyên, sau đó xuất ra các phần tử thỏa mãn yêu cầu VD.
//Input: 11 
//2 1 6 5 2 4 8 9 0 18 2 
//Output: 1 6 2 8 0 2 

namespace bai1
{
    class Program
    {
        static bool kiemTra(int n)
        {
            if (n == 2)
            {
                return true;
            }
            else if (n < 2)
            {
                return false;
            }
            else
            {
                for(int i=2; i<=Math.Sqrt(n); i++)
                {
                    if(n%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            

        }
        static void Nhap( int [] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a["+ i +"]= ");
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static void Xuat(int []a, int n)
        {
            for(int i = 0; i < n; i++)
            {
               
                if (kiemTra(i+1)==true)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
           
            Console.WriteLine("nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhap(a, n);
            Xuat(a, n);
            Console.ReadKey();
        }
    }
}
