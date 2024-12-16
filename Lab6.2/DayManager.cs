using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
        // Lớp DayManager quản lý các thao tác với Hashtable
        public class DayManager
        {
            private Hashtable daysOfWeek;

            public DayManager()
            {
                // Tạo Hashtable lưu danh sách các ngày trong tuần với key từ 1-8
                daysOfWeek = new Hashtable();
                daysOfWeek.Add(1, "Monday");
                daysOfWeek.Add(2, "Tuesday");
                daysOfWeek.Add(3, "Wednesday");
                daysOfWeek.Add(4, "Thursday");
                daysOfWeek.Add(5, "Friday");
                daysOfWeek.Add(6, "Saturday");
                daysOfWeek.Add(7, "Sunday");
                daysOfWeek.Add(8, "Extra Day");
            }

            // Tìm ngày trong tuần theo giá trị (value)
            public void FindDay(string dayName)
            {
                bool found = false;
                foreach (DictionaryEntry day in daysOfWeek)
                {
                    if (day.Value.ToString().Equals(dayName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found: Key = {day.Key}, Value = {day.Value}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"{dayName} not found in the Hashtable.");
                }
            }

            // In ra các ngày trong tuần bao gồm cả key và value
            public void DisplayDays()
            {
                Console.WriteLine("\nDays of the week (Key and Value):");
                foreach (DictionaryEntry day in daysOfWeek)
                {
                    Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
                }
            }
        }
    }


