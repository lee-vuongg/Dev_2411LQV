using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
                // Tạo phòng ban IT với 3 nhân viên
                Department department = new Department("IT Department", 3);

                // Thêm nhân viên vào phòng ban thông qua indexer
                department[0] = new Employee(1, "Alice", 25);
                department[1] = new Employee(2, "Bob", 30);
                department[2] = new Employee(3, "Charlie", 28);

                // Hiển thị toàn bộ thông tin nhân viên
                Console.WriteLine("Danh sách nhân viên:");
                department.DisplayAllEmployees();

                // Truy cập một nhân viên cụ thể
                Console.WriteLine("\nTruy cập nhân viên thứ 2:");
                department[1].Display();

                // Chỉnh sửa thông tin nhân viên thứ 2
                Console.WriteLine("\nCập nhật thông tin nhân viên thứ 2:");
                department[1] = new Employee(2, "Bob Updated", 31);
                department[1].Display();
            Console.WriteLine();
            }
        }
    }

