

using System;
using System.Collections;
using System.Text;

namespace lesion05
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            // arrayList
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("LeQuocVuong");
            int[] arr = new int[8] { 8, 5, 6, 66, 77, 00,99, 1000};
            arrList.AddRange(arr);
            Console.WriteLine("Chuỗi");
            //Hiển Thị
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            Console.WriteLine("________________");
            //arrList.Sort();
            //Console.WriteLine("Chuỗi Kí Tự");
            ////Sắp Xếp -Phải Cùng Dữ Liệu
            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}
            //Console.WriteLine("________________");
            //Xóa Sữ Liệu
            arrList.RemoveAt(0);
            Console.WriteLine("Chuỗi Kí Tự thứ nhật");
            //Sắp Xếp -Phải Cùng Dữ Liệu
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
           
            arrList.Remove(8);
            Console.WriteLine("Chuỗi Kí Tự là 8");
            //Sắp Xếp -Phải Cùng Dữ Liệu
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
          
            arrList.RemoveRange(3, 2);
            Console.WriteLine("Chuỗi Kí Tự là 3 va 5");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }
            Console.WriteLine(" truoc khi clear" + arrList.Count);
            arrList.Clear();
            Console.WriteLine("clear" + arrList.Count);
            Console.WriteLine("________________");
            Console.WriteLine("________________");
            Console.WriteLine("________________");
            //Hash Table 
            Hashtable hashtable = new Hashtable();
             hashtable.Add("HR", "HUman Resoure");
             hashtable.Add("IT", "Information Technology ");
            hashtable["MK"] = "Maketting";
            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine("Key" + key +"\t value:" + hashtable[key]);

            }
            //Hiển Thị Dữ Liệu

        }
    }
}
