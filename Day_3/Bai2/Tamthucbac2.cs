using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai2
{
    class Tamthucbac2
    {
        float a, b, c;

        //public float A { get => a; set => a = value; }
        //public float B { get => b; set => b = value; }
        //public float C { get => c; set => c = value; }
       

        public void SetA(float A)
        {
            a = A;
        }
        public void SetB(float B)
        {
            b = B;
        }
        public void SetC(float C)
        {
            c = C;
        }
       
        public void Showinfor()
        {
            Console.WriteLine(a + "*x^2" + " + " + b + "*x" + "+ " + c);
        }
       public static Tamthucbac2 operator *( Tamthucbac2 ttb1,Tamthucbac2 doidau)
        {
            Tamthucbac2 TTB1 = new Tamthucbac2();
            TTB1.SetA(ttb1.a * doidau.a);
            TTB1.SetB(ttb1.b * doidau.b);
            TTB1.SetC(ttb1.c * doidau.c);
           
            return TTB1;
          
        }
        

        public static Tamthucbac2 operator+( Tamthucbac2 TTB1,Tamthucbac2 TTB2)
        {
            Tamthucbac2 ttb3 = new Tamthucbac2();
            ttb3.SetA(TTB1.a+ TTB2.a);
            ttb3.SetB(TTB1.b + TTB2.b);
            ttb3.SetC(TTB1.c+ TTB2.c);
            return ttb3;
        }

        public static Tamthucbac2 operator -(Tamthucbac2 TTB1, Tamthucbac2 TTB2)
        {
            Tamthucbac2 ttb3 = new Tamthucbac2();
            ttb3.SetA(TTB1.a - TTB2.a);
            ttb3.SetB(TTB1.b - TTB2.b);
            ttb3.SetC(TTB1.c - TTB2.c);


            return ttb3;
        }
        public static Tamthucbac2 operator -(Tamthucbac2 tamThucBacHai)
        {
            Tamthucbac2 doidau = new Tamthucbac2();
            {
                doidau.SetA ( -tamThucBacHai.a);
                doidau.SetB(-tamThucBacHai.b);
                doidau.SetC(-tamThucBacHai.c);

            };
            return doidau;
        }
    }
}
