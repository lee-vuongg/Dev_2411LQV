using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6._1.BookManager;

namespace Lab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách sách
            List<Book> books = new List<Book>
            {
                new Book(1, "Book A", "Author 1", "Nhi Dong", 2014, 10.5),
                new Book(2, "Book B", "Author 2", "Kim Dong", 2015, 15.0),
                new Book(3, "Book C", "Author 3", "Nhi Dong", 2014, 20.0),
                new Book(4, "Book D", "Author 4", "Publisher 1", 2016, 5.0),
                new Book(5, "Book E", "Author 5", "Publisher 2", 2014, 12.5),
                new Book(6, "Book F", "Author 6", "Publisher 3", 2013, 18.0),
                new Book(7, "Book G", "Author 7", "Publisher 4", 2017, 7.5),
                new Book(8, "Book H", "Author 8", "Publisher 5", 2018, 9.0),
                new Book(9, "Book I", "Author 9", "Nhi Dong", 2014, 11.0),
                new Book(10, "Book J", "Author 10", "Publisher 6", 2019, 13.5),
            };

            // In danh sách sách sắp xếp theo giá tăng dần
            Console.WriteLine("Books sorted by price (ascending):");
            var sortedBooks = books.OrderBy(b => b.Price).ToList();
            sortedBooks.ForEach(b => b.Display());

            // Tìm sách có Title trùng với giá trị nhập vào
            Console.Write("\nEnter the title to search: ");
            string searchTitle = Console.ReadLine();
            var foundBooks = books.Where(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundBooks.Count > 0)
            {
                Console.WriteLine("Found books:");
                foundBooks.ForEach(b => b.Display());
            }
            else
            {
                Console.WriteLine("No books found with the given title.");
            }

            // In sách xuất bản năm 2014
            Console.WriteLine("\nBooks published in 2014:");
            var books2014 = books.Where(b => b.Year == 2014).ToList();
            books2014.ForEach(b => b.Display());

            // Xóa sách của nhà xuất bản "Nhi Dong"
            Console.WriteLine("\nRemoving books published by 'Nhi Dong'...");
            books.RemoveAll(b => b.Publisher.Equals("Nhi Dong", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Updated book list:");
            books.ForEach(b => b.Display());
        }
    }
}

        