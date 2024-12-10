using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_BTLAB3._2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // Tạo đối tượng Book bằng constructor mặc định
            Book defaultBook = new Book();
            Console.WriteLine("Sách mặc định:");
            defaultBook.Display();

            Console.WriteLine();

            // Tạo đối tượng Book với constructor đầy đủ tham số
            Book myBook = new Book("J.K. Rowling", 500, "978-3-16-148410-0", "Harry Potter", 1);
            Console.WriteLine("Sách của tôi:");
            myBook.Display();

            Console.WriteLine();

            // Thử lật trang
            Console.WriteLine("Lật sang trang tiếp theo:");
            myBook.FlipPageForward();
            myBook.Display();

            Console.WriteLine();

            Console.WriteLine("Lật về trang trước:");
            myBook.FlipPageBackward();
            myBook.Display();
            Console.ReadLine();
        }
    }

}
