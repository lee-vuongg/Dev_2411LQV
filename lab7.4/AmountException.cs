using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7._4
{
        public class AmountException : Exception
        {
            public AmountException(string message) : base(message) { }
        }

        // Lớp Lecture
        public class Lecture
        {
            public string Name { get; set; }
            private decimal salary;
            private decimal bonus;

            public decimal Salary
            {
                get { return salary; }
                set
                {
                    if (value < 60000)
                        throw new AmountException($"Lương phải lớn hơn hoặc bằng 60,000$. Lương hiện tại: {value}$");
                    salary = value;
                }
            }

            public decimal Bonus
            {
                get { return bonus; }
                set
                {
                    if (value > 10000)
                        throw new AmountException($"Thưởng phải nhỏ hơn hoặc bằng 10,000$. Thưởng hiện tại: {value}$");
                    bonus = value;
                }
            }

            public Lecture(string name, decimal salary, decimal bonus)
            {
                Name = name;
                Salary = salary;
                Bonus = bonus;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Lecture Name: {Name}, Salary: {Salary}$, Bonus: {Bonus}$");
            }
        }
    }

