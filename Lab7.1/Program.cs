using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DongVat.AnThit;
using DongVat.AnCo;


namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test các lớp trong AnCo
            Bo bo = new Bo("B001", "Bò Vàng", 500);
            bo.DisplayInfo();

            Trau trau = new Trau("T001", "Trâu Đen", 700);
            trau.DisplayInfo();

            De de = new De("D001", "Dê Núi", 120);
            de.DisplayInfo();

            // Test các lớp trong AnThit
            CaSau caSau = new CaSau("CS001", "Cá Sấu", 300);
            caSau.DisplayInfo();

            Ho ho = new Ho("H001", "Hổ Bengal", 250);
            ho.DisplayInfo();

            SuTu suTu = new SuTu("ST001", "Sư Tử", 200);
            suTu.DisplayInfo();


        }
    }
}
