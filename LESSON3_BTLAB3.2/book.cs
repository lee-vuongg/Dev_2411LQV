using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_BTLAB3._2
{
    using System;

    public class Book
    {
        // Thuộc tính
        public string Author { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int CurrentPage { get; set; }

        // Constructor mặc định
        public Book()
        {
            CurrentPage = 1;
        }

        // Constructor với đầy đủ tham số
        public Book(string author, int pages, string isbn, string title, int currentPage)
        {
            Author = author;
            Pages = pages;
            ISBN = isbn;
            Title = title;
            CurrentPage = currentPage;
        }

        // Phương thức lật sang trang tiếp theo
        public void FlipPageForward()
        {
            if (CurrentPage < Pages)
            {
                CurrentPage++;
            }
            else
            {
                Console.WriteLine("Bạn đang ở trang cuối cùng.");
            }
        }

        // Phương thức lật về trang trước
        public void FlipPageBackward()
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
            }
            else
            {
                Console.WriteLine("Bạn đang ở trang đầu tiên.");
            }
        }

        // Phương thức hiển thị thông tin
        public void Display()
        {
            Console.WriteLine($"Tác giả: {Author}");
            Console.WriteLine($"Tiêu đề: {Title}");
            Console.WriteLine($"Số trang: {Pages}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Trang hiện tại: {CurrentPage}");
        }
    }

}
