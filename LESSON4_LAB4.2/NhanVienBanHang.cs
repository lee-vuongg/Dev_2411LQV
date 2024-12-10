using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._2
{
    using System;

    class NhanVienBanHang : NhanVien
    {
        public int SoLuongBanDuoc { get; set; }
        private const double LuongCoBan = 300000; // Lương cơ bản mỗi sản phẩm

        public override double TinhLuong()
        {
            return SoLuongBanDuoc * LuongCoBan;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Nhân viên bán hàng: {Ten}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Số lượng bán được: {SoLuongBanDuoc}");
            Console.WriteLine($"Lương: {TinhLuong()}");
        }
    }

}
