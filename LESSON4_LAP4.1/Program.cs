using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAP4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.InputEncoding = System.Text.Encoding.UTF8;
            // Tạo tài khoản thường
            Account account = new Account(1000);
            account.Deposit(500);
            account.WithDraw(300);
            Console.WriteLine($"Số dư cuối: {account.GetBalance()}");

            // Tạo tài khoản tiết kiệm
            SavingAccount savingAccount = new SavingAccount(2000, 5); // 5% lãi suất
            Console.WriteLine($"Lãi suất: {savingAccount.GetInterest()}");

            // Tạo tài khoản vãng lai
            CheckAccount checkAccount = new CheckAccount(1500, 20); // 20 phí giao dịch
            checkAccount.Deposit(300);
            checkAccount.WithDraw(500);
            Console.WriteLine($"Số dư cuối: {checkAccount.GetBalance()}");
            Console.WriteLine();
        }
    }

}
