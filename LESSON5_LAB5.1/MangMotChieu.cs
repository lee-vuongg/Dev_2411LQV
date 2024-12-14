using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_LAB5._1
{
    using System;

    public class MangMotChieu
    {
        private int[] arr;

        // Constructor khởi tạo mảng 1 chiều
        public MangMotChieu()
        {
            arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(-100, 100); // Khởi tạo số ngẫu nhiên từ -100 đến 100
            }
        }

        // Phương thức in mảng
        public void InMang()
        {
            Console.WriteLine("Mảng hiện tại: " + string.Join(", ", arr));
        }

        // Tìm phần tử nhỏ nhất
        public int TimMin()
        {
            int min = arr[0];
            foreach (var x in arr)
            {
                if (x < min) min = x;
            }
            return min;
        }

        // Đảo ngược mảng
        public void DaoNguoc()
        {
            Array.Reverse(arr);
        }

        // Sắp xếp mảng tăng hoặc giảm
        public void SapXep(bool tangDan = true)
        {
            if (tangDan)
                Array.Sort(arr);
            else
                Array.Sort(arr, (a, b) => b.CompareTo(a));
        }

        // Tìm số nguyên tố
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        public void TimSoNguyenTo()
        {
            Console.WriteLine("Các số nguyên tố trong mảng:");
            foreach (var x in arr)
                if (LaSoNguyenTo(x))
                    Console.Write(x + " ");
            Console.WriteLine();
        }

        // Tính trung bình cộng số dương
        public double TinhTrungBinhCongDuong()
        {
            int sum = 0, count = 0;
            foreach (var x in arr)
            {
                if (x > 0)
                {
                    sum += x;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0;
        }
    }

}
