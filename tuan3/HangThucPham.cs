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
                if (donGia <= 0)
                    throw new Exception("Khong hop le");

            }
        }
        public DateTime NgaySX
        {

        }
    }

}
