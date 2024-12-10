using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._3
{
    using System;

    interface IStorage
    {
        string Data { get; set; } // Thuộc tính dữ liệu
        void Read(string filename); // Đọc dữ liệu từ file
        void Write(string filename); // Ghi dữ liệu vào file
    }

}
