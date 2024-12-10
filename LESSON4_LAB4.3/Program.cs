using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Document doc = new Document();

            // Ghi dữ liệu vào file
            doc.Data = "Chào mừng bạn đến với lập trình C#!";
            Console.WriteLine($"Nội dung gốc: {doc.Data}");
            doc.Write("document.txt");

            // Mã hóa dữ liệu
            doc.Encrypt();
            Console.WriteLine($"Nội dung sau mã hóa: {doc.Data}");

            // Giải mã dữ liệu
            doc.Decrypt();
            Console.WriteLine($"Nội dung sau giải mã: {doc.Data}");

            // Đọc dữ liệu từ file
            doc.Read("document.txt");
            Console.WriteLine($"Nội dung đọc từ file: {doc.Data}");
            Console.WriteLine();
        }
    }

}
