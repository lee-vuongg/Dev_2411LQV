using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_BTlab3._1
{
    using System;

    public class Employee
    {
        // Thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public double SalaryLevel { get; set; }
        public static double BasicSalary = 3000; // Lương cơ bản dùng chung

        // Phương thức tính thu nhập
        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        // Phương thức hiển thị thông tin
        public void Display()
        {
            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Họ tên: {Name}");
            Console.WriteLine($"Năm sinh: {YearOfBirth}");
            Console.WriteLine($"Lương cơ bản: {BasicSalary}");
            Console.WriteLine($"Thu nhập: {GetIncome()}");
        }
    }

}
