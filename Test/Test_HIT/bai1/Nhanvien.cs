using System;
using System.Collections.Generic;
using System.Text;


//Một công ty sản xuất máy in quản lý thông tin về nhân viên bao gồm : Mã nhân viên, họ tên, hệ số lương, số ngày công, trợ cấp.

//Biết rằng, lương của nhân viên được tính như sau: 
//Lương= hệ số lương* 150.000 * số ngày công + trợ cấp
//Nếu trong 1 tháng làm nhân viên đó không nghỉ buổi nào(đủ 26 buổi) thì sẽ được nhận tiền trợ cập, ngược lại thì sẽ không nhận được tiền trợ cấp và sẽ bị trừ lương tính theo số ngày nghỉ
//(lương bị trừ= số ngày nghỉ*hệ số lương*10.000 )

namespace bai1
{
    class Nhanvien
    {
        private string manv;
        private string hoten;
        private float heso;
        private int songay;
        private float trocap;

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public float Heso { get => heso; set => heso = value; }
        public int Songay { get => songay; set => songay = value; }
        public float Trocap { get => trocap; set => trocap = value; }
        public string Getten()
        {
            return hoten;
        }

        public void Nhap()
        {
            Console.WriteLine("nhap ma nhan vien: ");
            this.Manv = Console.ReadLine();
            Console.WriteLine("\n nhap ho ten: ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("\n nhap he so luong: ");
            this.Heso = float.Parse(Console.ReadLine());
            Console.WriteLine("\n nhap so ngay: ");
            this.Songay = int.Parse(Console.ReadLine());
            Console.WriteLine("\n nhap tro cap: ");
            this.Trocap = int.Parse(Console.ReadLine());

        }
        //Lương= hệ số lương* 150.000 * số ngày công + trợ cấp
        public float Luong()
        {
            int SoNgayNghi = 26 - this.Songay;
            if (this.Songay == 26)
            {
                return Heso * 150000 * Songay + Trocap;

            }
            return Heso * 150000 * Songay + Trocap-(SoNgayNghi * Heso * 150000 + SoNgayNghi * Heso);
            
        }
        public void Xuat()
        {
            Console.WriteLine("MNV: " + this.Manv + " ho ten: " + this.Hoten + " he so luong: " + 
                this.Heso + " so ngay: " + this.Songay + " tro cap: " + this.Trocap+"\n luong: "+this.Luong());
        }
        

        

    }
}
