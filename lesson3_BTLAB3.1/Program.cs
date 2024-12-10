using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_BTlab3._1
{
    using System;

    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Tạo đối tượng Employee
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Nguyễn Văn A",
                YearOfBirth = 1995,
                SalaryLevel = 2.5
            };

            // Gọi phương thức hiển thị thông tin
            employee.Display();
            Console.ReadLine();
        }
    }

}
