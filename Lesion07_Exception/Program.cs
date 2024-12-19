using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesion07_Exception
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int number;
            //Console.WriteLine("Nhập vào một số bất kỳ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Số Bạn Vừa Nhập là :" + number);


            //try
            //{
            //    int a = 123456, b = 654, c;
            //    c = a / b;
            //    Console.WriteLine("giá trị là :" + c);
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Thông báo lỗi" + ex.Message);

            //}
            //Console.WriteLine("Devmaster");
            //// nếu không biết thuộc ễcption nào thì có thể dùng
            //try
            //{
            //    int a = 123456, b = 654, c;
            //    c = a / b;
            //    Console.WriteLine("giá trị là :" + c);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Thông báo lỗi" + ex.Message);

            //}
            //Console.WriteLine("Devmaster");
            string[] names = { "Vương", "Hương" };
            // exception bằng nhau
            try
            {
                Console.WriteLine("Khối try catch ngoài");
                try
                {
                    int a = 123456, b = 654, c;
                    c = a / b;
                    Console.WriteLine("giá trị là :" + c);
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Khối Try catch Trong");
                    Console.WriteLine("Thông báo lỗi" + ex.Message);

                }
                names[2] = "huy";

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Kối Try Catch ngoài");
                Console.WriteLine(ex.Message);
            }



            //lưu ý 
            // -Khối catch bê trên là tâp con cua khối catch bên dưới 
            //-hoặc khối catch bên trên 
            //NHiều khối catch
            try
            {
                int a = 123456, b = 654, c;
                c = a / b;
                names[2] = "huy";
                Console.WriteLine("giá trị là :" + c);
            }
            catch ( IndexOutOfRangeException ex)
            {
                Console.WriteLine("Khối Try catch 1");
                Console.WriteLine("Thông báo lỗi" + ex.Message);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Khối Try catch 2");
                Console.WriteLine("Thông báo lỗi" + ex.Message);

            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Khối Try catch 3");
                Console.WriteLine("Thông báo lỗi" + ex.Message);

            }
            //finally
            try
            {
                int a = 123456, b = 654, c;
                c = a / b;
                names[2] = "huy";
                Console.WriteLine("giá trị là :" + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Khối Try catch 1");
                Console.WriteLine("Thông báo lỗi" + ex.Message);

            }
            finally {
                Console.WriteLine("Khối finally");
            }
            Console.WriteLine("-------------------------------------------------");
            
            Product product = new Product(); 
            try
            {
                product.Price = 0;
                Console.WriteLine("Giá Là:" +product.Price);
            }
            catch(InvalidPriceException  ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

