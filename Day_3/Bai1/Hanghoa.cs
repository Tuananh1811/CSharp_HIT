using System;
using System.Collections.Generic;
using System.Text;


//Cài đặt lớp Hàng Hóa với các thuộc tính: Mã hàng, Tên hàng, Đơn giá, Số lượng và các phương thức: 
//NHAP: nhập thông tin của mặt hàng.
//XUAT: xuất thông tin của mặt hàng lên màn hình (dữ liệu xuất trên 1 dòng) kèm theo Thành tiền. (Thành tiền = số lượng* Đơn giá)
//SAPXEP: sắp xếp các mặt hàng theo chiều tăng dần của thành tiền
//------------- 
//Viết hàm main nhập vào một danh sách gồm n mặt hàng.In danh sách các mặt hàng vừa nhập ra màn hình theo chiều tằng dần của Thành Tiền

namespace Bai1
{
    public class Hanghoa
    {
        private int maHang;
        private string tenHang;

        private int donGia;
        private int soLuong;
        

        public int MaHang
        {
            set { maHang = value; }
            get { return maHang; }
        }
        public string Tenhang
        {
            set { tenHang = value;}
            get{  return tenHang;}
        }
        public int DonGia
        {
            set {   DonGia = value; }
            get { return donGia; }
        }
        public int SoLuong
        {
            set { SoLuong = value; }
            get { return soLuong; }
        }
       
      
        public void Nhap()
        {
                Console.WriteLine("nhap ma hang: ");
                this.maHang = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap ten hang: ");
                this.tenHang = Console.ReadLine();
                Console.WriteLine("nhap don gia: ");
                this.donGia = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap so luong: ");
                this.soLuong = int.Parse(Console.ReadLine());
                Console.WriteLine("===============");
                
           
        }
        public void Xuat()
        {
            Console.WriteLine("ma hang: " + this.maHang + ", " + "ten hang: " + this.tenHang + " ," +
                "don gia: " + this.donGia + ", " + "so luong: " + this.soLuong+" ,"+
               "thanh tien= "+this.donGia*this.soLuong);
        }
        public int ThanhTien()
        {
            return soLuong * donGia;
        }

        //public void Nhap(Hanghoa hanghoa)
        //{
        //    Console.WriteLine("nhap ma hang: ");
        //    hanghoa.maHang = int.Parse(Console.ReadLine());
        //    Console.WriteLine("nhap ten hang: ");
        //    hanghoa.tenHang = Console.ReadLine();
        //    Console.WriteLine("nhap don gia: ");
        //    hanghoa.donGia = int.Parse(Console.ReadLine());
        //    Console.WriteLine("nhap so luong: ");
        //    hanghoa.soLuong = int.Parse(Console.ReadLine());
        //    Console.WriteLine("===============");
        //}
        //public void Xuat(Hanghoa hanghoa)
        //{
        //    Console.WriteLine("ma hang: " + hanghoa.maHang + ", " + "ten hang: " + hanghoa.tenHang + " ," +
        //        "don gia: " + hanghoa.donGia + ", " + "so luong: " + hanghoa.soLuong+" ,"+
        //        "thanh tien= "+hanghoa.donGia*hanghoa.soLuong);
        //}
    }
}
