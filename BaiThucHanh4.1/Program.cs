using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4._1
{
    using System;

    class Program
    {
        static void Main()
        {
            // Tạo tài khoản thường
            Account account = new Account(1000);
            account.Deposit(500);
            account.WithDraw(200);
            Console.WriteLine($"Số dư tài khoản thường: {account.GetBalance()}");

            // Tạo tài khoản tiết kiệm
            SavingAccount savingAccount = new SavingAccount(2000, 0.05m);
            Console.WriteLine($"Lãi suất tài khoản tiết kiệm: {savingAccount.GetInterest()}");

            // Tạo tài khoản kiểm tra
            CheckAccount checkAccount = new CheckAccount(1500, 20);
            checkAccount.Deposit(500);
            checkAccount.WithDraw(300);
            Console.WriteLine($"Số dư tài khoản kiểm tra: {checkAccount.GetBalance()}");
        }
    }

}
