using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            HangThucPham tp = new HangThucPham();
            int a;
            Console.WriteLine("Nhap so luong thuc pham: ");
            a = Int32.Parse(Console.ReadLine());
            HangThucPham[] arr = new HangThucPham[a];
            for (int i = 0; i < a; i++)
            {
                HangThucPham t = new HangThucPham();
                t.nhap(t);
                arr[i] = t;

            }
            tp.x();
            for (int i = 0; i < a; i++)
            {
                arr[i].xuat();
            }

            Console.ReadLine();
        }
    }
}
