using System;

namespace Lab6._1
{
    namespace BookManager
    {
        // Định nghĩa lớp Book
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }

            public Book(int id, string title, string author, string publisher, int year, double price)
            {
                Id = id;
                Title = title;
                Author = author;
                Publisher = publisher;
                Year = year;
                Price = price;
            }

            public void Display()
            {
                Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {Year}, Price: {Price}");
            }
        }
    }

}
