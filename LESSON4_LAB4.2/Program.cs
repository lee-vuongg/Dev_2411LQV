using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            NhanVienBanHang nvBanHang = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn A",
                DiaChi = "Hà Nội",
                SoLuongBanDuoc = 15
            };

            CongNhan congNhan = new CongNhan
            {
                Ten = "Trần Thị B",
                DiaChi = "TP Hồ Chí Minh",
                SoLuongSanPham = 10
            };

            Console.WriteLine("Thông tin nhân viên bán hàng:");
            nvBanHang.HienThi();

            Console.WriteLine("\nThông tin công nhân:");
            congNhan.HienThi();
            Console.WriteLine();
        }
    }

}
