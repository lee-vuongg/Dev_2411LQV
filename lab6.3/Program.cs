using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng CarManager
            CarManager manager = new CarManager();

            // Hiển thị danh sách ban đầu
            Console.WriteLine("Initial Car List:");
            manager.DisplayCars();

            // Xóa các xe có màu Red
            manager.RemoveRedCars();

            // Hiển thị danh sách sau khi xóa
            Console.WriteLine("Updated Car List:");
            manager.DisplayCars();
        }
    }
}
