using System;

namespace bai4
{
    class Program
    {
        struct Date
        {
            public int Day;
            public int Month;
            public int Year;
        }
        struct Student
        {
            public int ID;
            public String Name;
            public Date DateOfBirth;
        }
        static void Nhap_St(out Student st)
        {
            Console.WriteLine("nhap ID sinh vien: ");
            st.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten: ");
            st.Name= Console.ReadLine();
            Console.WriteLine("nhap ngay, thang, nam lan luot: ");
            st.DateOfBirth.Day= int.Parse(Console.ReadLine());
            st.DateOfBirth.Month = int.Parse(Console.ReadLine());
            st.DateOfBirth.Year = int.Parse(Console.ReadLine());

        }
       static void xuat_St( Student st)
        {
            Console.WriteLine("ID: " + st.ID);
            Console.WriteLine("ten: " + st.Name); 
            Console.WriteLine("ngay thang nam sinh: " + st.DateOfBirth.Day+ " / " + st.DateOfBirth.Month + " / " + st.DateOfBirth.Year);
        }
        
       
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so sv: ");
            int n = int.Parse(Console.ReadLine());
            Student[] List_St = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sv thu " + (i + 1));
                Nhap_St(out List_St[i]);
            }
            Console.WriteLine("xuat danh sach sinh vien: ");
            for (int i=0; i < n; i++){
                xuat_St(List_St[i]);

            }
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (List_St[i].DateOfBirth.Year > List_St[j].DateOfBirth.Year)
                    {
                        Student tg = List_St[i];
                        List_St[i] = List_St[j];
                        List_St[j] = tg;
                    }
                }
            }
            Console.WriteLine("Danh sach sau khi sap xep theo nam sinh: ");
            Console.WriteLine("Ma sv\tTen\tNgay sinh");
            for (int i = 0; i < n; i++)
            {
                xuat_St(List_St[i]);
            }
            Console.ReadKey();

        }
    }
}
