using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng DayManager
            DayManager dayManager = new DayManager();

            // Tìm ngày "Tuesday"
            Console.WriteLine("Searching for 'Tuesday'...");
            dayManager.FindDay("Tuesday");

            // In danh sách các ngày trong tuần
            dayManager.DisplayDays();

        }
    }
}
