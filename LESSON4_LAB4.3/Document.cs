using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAB4._3
{
    using System;
    using System.IO; // Thư viện làm việc với FileStream và StreamReader/Writer

    class Document : IStorage, IEncryptable
    {
        public string Data { get; set; } // Nội dung của tài liệu

        public void Read(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    Data = reader.ReadToEnd();
                }
                Console.WriteLine("Đọc dữ liệu từ file thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            }
        }

        public void Write(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write(Data);
                }
                Console.WriteLine("Ghi dữ liệu vào file thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
            }
        }

        public void Encrypt()
        {
            if (!string.IsNullOrEmpty(Data))
            {
                char[] charArray = Data.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    charArray[i] = (char)(charArray[i] + 1); // Dịch ký tự
                }
                Data = new string(charArray);
                Console.WriteLine("Dữ liệu đã được mã hóa.");
            }
        }

        public void Decrypt()
        {
            if (!string.IsNullOrEmpty(Data))
            {
                char[] charArray = Data.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    charArray[i] = (char)(charArray[i] - 1); // Dịch ngược ký tự
                }
                Data = new string(charArray);
                Console.WriteLine("Dữ liệu đã được giải mã.");
            }
        }
    }

}
