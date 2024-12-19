using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.Sony;
using samsung = Electronic.Samsung;


namespace lesion07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sử dụng namespace 
            //Cách 1 
            XperiaZ xperiaZ = new XperiaZ();
            //cách 2 sử dụng tên namespace .class sử dụng
            Electronic.Tivi tivi = new Electronic.Tivi();
            //Cách 3 Sử dụng tên alias ~ Bí danh
            //Đăt Tên Cho namespace -> sử dụng alias.tên class
            samsung.GalaxyA galaxyA = new samsung.GalaxyA();
            samsung.GalaxyS galaxyS = new samsung.GalaxyS();
            samsung.MayGiat mayGiat = new samsung.MayGiat();





        }
    }
}
