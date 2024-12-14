using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_LAB5._2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            MangHaiChieu mang2D = new MangHaiChieu();

            Console.WriteLine("Mảng 2 chiều:");
            mang2D.InMang();

            Console.WriteLine("\nTổng các phần tử trên đường chéo chính: " + mang2D.TongDuongCheoChinh());

            Console.WriteLine("\nPhần tử nhỏ nhất trên mỗi cột:");
            mang2D.MinMoiCot();

            Console.WriteLine("\nCác phần tử nằm trên đường viền:");
            mang2D.PhanTuDuongVien();
            Console.WriteLine();
        }
    }

}
