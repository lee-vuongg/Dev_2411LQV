using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tạo giảng viên hợp lệ
                Lecture lecture1 = new Lecture("John Doe", 65000, 8000);
                lecture1.DisplayInfo();

                // Tạo giảng viên với lương không hợp lệ
                Lecture lecture2 = new Lecture("Jane Smith", 55000, 5000);
                lecture2.DisplayInfo();
            }
            catch (AmountException ex)
            {
                Console.WriteLine($"Ngoại lệ xảy ra: {ex.Message}");
            }

            try
            {
                // Tạo giảng viên với thưởng không hợp lệ
                Lecture lecture3 = new Lecture("Emily Johnson", 70000, 15000);
                lecture3.DisplayInfo();
            }
            catch (AmountException ex)
            {
                Console.WriteLine($"Ngoại lệ xảy ra: {ex.Message}");
            }

            Console.WriteLine("Kết thúc chương trình.");
        }
    }
}
