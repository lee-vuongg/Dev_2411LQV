using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._2
{
    using System;

    abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        public abstract double TinhLuong(); // Phương thức trừu tượng tính lương
        public abstract void HienThi();    // Phương thức trừu tượng hiển thị thông tin
    }

}
