using System;
using System.Collections.Generic;
using System.Text;


namespace bai1
{
    class Program
    {
      private  static void FindNV(List<Nhanvien> nhanvien,string ten)
        {
            foreach(Nhanvien x in nhanvien)
            {
                if (x.Getten() == ten)
                {
                    x.Xuat();
                }
            }
        }
        static void Main(string[] args)
        {
            List<Nhanvien> nhanvien = new List<Nhanvien>();
            Console.WriteLine("\n nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Nhanvien nhanVien = new Nhanvien();
                nhanVien.Nhap();
                nhanvien.Add(nhanVien);
            }
            Console.WriteLine("\n\t======danh sach thong tin nhan vien: ");
            foreach(Nhanvien x in nhanvien)
            {
                x.Xuat();
            }
            Console.WriteLine("nhap ten can tim: ");
            string ten = Console.ReadLine();
            FindNV(nhanvien,ten);

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nhanvien[i].Luong()>nhanvien[j].Luong())
                    {
                        Nhanvien tg = nhanvien[i];
                        nhanvien[i] = nhanvien[j];
                        nhanvien[j] = tg;

                    }
                }
            }
            Console.WriteLine("\n\t danh sach nhan vien theo thu tu tang dan cua luong: ");
            foreach(Nhanvien x in nhanvien)
            {
                x.Xuat();
            }
            Console.ReadKey();
            
        }
    }
}
