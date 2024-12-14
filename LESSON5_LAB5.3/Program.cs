using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_LAB5._3
{
    using System;

    class CanChi
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Khai báo mảng CAN và CHI
            string[] CAN = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] CHI = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            // Nhập năm dương lịch từ người dùng
            Console.Write("Nhập năm dương lịch: ");
            int nam = int.Parse(Console.ReadLine());

            // Tính chỉ số CAN và CHI
            int chiSoCAN = (nam - 2010) % 10; // 2010 là Canh => vị trí 7 trong CAN
            if (chiSoCAN < 0) chiSoCAN += 10;

            int chiSoCHI = (nam - 2010) % 12; // 2010 là Dần => vị trí 2 trong CHI
            if (chiSoCHI < 0) chiSoCHI += 12;

            // Xuất kết quả
            Console.WriteLine($"Năm {nam} là năm {CAN[chiSoCAN]} {CHI[chiSoCHI]}");
            Console.WriteLine();
        }
    }

}
