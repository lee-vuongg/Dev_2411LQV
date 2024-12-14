using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON5_5._4
{
        class Employee
        {
            // Các trường (fields)
            private int id;
            private string name;
            private int age;

            // Constructor
            public Employee(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;
            }

            // Thuộc tính (properties)
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            // Phương thức hiển thị thông tin nhân viên
            public void Display()
            {
                Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
            }
        }
    }

