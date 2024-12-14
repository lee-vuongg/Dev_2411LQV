using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_LAB5._2
{
    using System;

    public class MangHaiChieu
    {
        private int[,] matrix;
        private int rows = 4, cols = 4;

        // Constructor khởi tạo mảng 2 chiều
        public MangHaiChieu()
        {
            matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(1, 50); // Số ngẫu nhiên từ 1-50
        }

        // In mảng theo hàng
        public void InMang()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Tính tổng các phần tử có chỉ số hàng = chỉ số cột
        public int TongDuongCheoChinh()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
                sum += matrix[i, i];
            return sum;
        }

        // In phần tử nhỏ nhất trên từng cột
        public void MinMoiCot()
        {
            for (int j = 0; j < cols; j++)
            {
                int min = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                Console.WriteLine($"Cột {j + 1}: Min = {min}");
            }
        }

        // Tìm phần tử nằm trên đường viền
        public void PhanTuDuongVien()
        {
            Console.WriteLine("Các phần tử trên đường viền:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                        Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

}
