using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._2
{
    using System;

    class CongNhan : NhanVien
    {
        public int SoLuongSanPham { get; set; }
        private const double LuongSanPham = 200000; // Lương mỗi sản phẩm

        public override double TinhLuong()
        {
            return SoLuongSanPham * LuongSanPham;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Công nhân: {Ten}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Số lượng sản phẩm: {SoLuongSanPham}");
            Console.WriteLine($"Lương: {TinhLuong()}");
        }
    }

}
