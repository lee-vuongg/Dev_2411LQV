using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_LAB5._1
{
    class Program
    {
            static void Main()
            {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            MangMotChieu mang = new MangMotChieu();

                mang.InMang();
                Console.WriteLine("Phần tử nhỏ nhất: " + mang.TimMin());

                Console.WriteLine("\nĐảo ngược mảng:");
                mang.DaoNguoc();
                mang.InMang();

                Console.WriteLine("\nSắp xếp mảng tăng dần:");
                mang.SapXep(true);
                mang.InMang();

                Console.WriteLine("\nCác số nguyên tố trong mảng:");
                mang.TimSoNguyenTo();

                Console.WriteLine("\nTrung bình cộng các phần tử dương: " + mang.TinhTrungBinhCongDuong());
                Console.WriteLine();
            }

    }
}
