using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_5._4
{
    class Department
        {
            private string name;           // Tên phòng ban
            private Employee[] employees;  // Danh sách nhân viên

            // Constructor
            public Department(string name, int size)
            {
                this.name = name;
                employees = new Employee[size];
            }

            // Indexer để truy cập nhân viên trong mảng
            public Employee this[int index]
            {
                get
                {
                    if (index >= 0 && index < employees.Length)
                        return employees[index];
                    else
                        throw new IndexOutOfRangeException("Index out of range.");
                }
                set
                {
                    if (index >= 0 && index < employees.Length)
                        employees[index] = value;
                    else
                        throw new IndexOutOfRangeException("Index out of range.");
                }
            }

            // Phương thức hiển thị toàn bộ nhân viên trong phòng ban
            public void DisplayAllEmployees()
            {
                Console.WriteLine($"Department: {name}");
                foreach (var emp in employees)
                {
                    if (emp != null)
                        emp.Display();
                }
            }
        }
    }


