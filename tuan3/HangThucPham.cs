using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan3
{
    class HangThucPham
    {
        private int maHang;
        private string tenHang;
        private int donGia;
        private DateTime ngaySX;
        private DateTime ngayHH;

        public int MaHang
        {
            get { return maHang; }
            set
            {
                maHang = value;
                if (maHang < 0)
                    throw new Exception("Khong hop le");
            
            }
        }
        public string TenHang
        {
            get { return tenHang; }
            set
            {
                tenHang = value;
                tenHang = "";
            }
        }
        public int DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value;
                //if (donGia <= 0)
                //    throw new Exception("Khong hop le");

            }
        }
        public DateTime NgaySX
        {
            get { return ngaySX; }
            set { ngaySX = value; }
        }
        public DateTime NgayHH
        {
            get { return ngayHH; }
            set { ngayHH = value; }
        }
        public HangThucPham(int MaHang, string TenHang, int DonGia, DateTime NgaySX, DateTime NgayHH)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.DonGia = donGia;
            this.NgaySX = ngaySX;
            this.NgayHH = ngayHH;
        }

        public HangThucPham()
        {
            // TODO: Complete member initialization
        }
        //private void setMaHang(String MaHang) throws Exception{
        //    if(!aHang.trim().equals(""))
        //        this.maHang = maHang;
        //    else throw new Exception("Loi: Ma hang rong");
        //}
        public HangThucPham nhap(HangThucPham a)
        {

            Console.WriteLine("Nhap ma hang: ");
            a.maHang = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten hang: ");
            a.tenHang = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            a.donGia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay san xuat: ");
            a.ngaySX = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay het han: ");
            a.ngaySX = DateTime.Now;
            return a;
        }
        public void x()
        {
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("Ma_Hang \tTen_Hang \tDon_Gia \tNgay_San_Xuat \tNgayHetHan \tGhiChu");
        }
        public void xuat()
        { 
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4}", maHang, tenHang, donGia, ngaySX.ToString("dd/MM/yyyy"), ngayHH.ToString("dd/MM/yyyy"));
        }
    }

}
