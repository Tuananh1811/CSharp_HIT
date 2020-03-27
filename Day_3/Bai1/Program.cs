using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hanghoa> hangHoa = new List<Hanghoa>();
           
            Console.WriteLine("nhap so mat hang can: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Hanghoa hanghoa = new Hanghoa();
                hanghoa.Nhap();
                hangHoa.Add(hanghoa);

            }
            foreach(Hanghoa x in hangHoa)
            {
                
                x.Xuat();
            }
            Console.WriteLine("danh sach cac mat hang theo chieu tang dan cua thanh tien ");
          
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (hangHoa[i].ThanhTien() > hangHoa[j].ThanhTien())
                    {
                        Hanghoa tg = hangHoa[i];
                        hangHoa[i] = hangHoa[j];
                        hangHoa[j] = tg;

                    }
                }
            }
            foreach (Hanghoa x in hangHoa)
            {

                x.Xuat();
            }



            Console.ReadKey();
        }
    }
}
