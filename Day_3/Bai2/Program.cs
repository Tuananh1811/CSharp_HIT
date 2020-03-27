using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamthucbac2 ttb1 = new Tamthucbac2();
                ttb1.SetA(2);
                ttb1.SetB(3);
                ttb1.SetC(4);
            ttb1.Showinfor();
            Tamthucbac2 ttb2 = new Tamthucbac2();
                ttb2.SetA(4);
                ttb2.SetB(5);
                ttb2.SetC(6);
            ttb2.Showinfor();
            Tamthucbac2 TTB1 = new Tamthucbac2();
            Tamthucbac2 TTB2 = new Tamthucbac2();
            TTB1 = -ttb1;
            Console.WriteLine("tam thuc 1 sau khi doi dau");
            TTB1.Showinfor();
            TTB2 = -ttb2;
            Console.WriteLine("tam thuc 2 sau khi doi dau");
            TTB2.Showinfor();


            Tamthucbac2 ttb3 = new Tamthucbac2();
            ttb3 = TTB1 + TTB2;
            Console.WriteLine("cong 2 tam thuc");
            ttb3.Showinfor();
            ttb3 = TTB1 - TTB2;
            Console.WriteLine("tru 2 tam thuc");
            ttb3.Showinfor();
           
            Console.ReadKey();

        }
    }
}
