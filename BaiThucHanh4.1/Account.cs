using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4._1
{
    public class Account
    {
        protected decimal Balance;

        public Account(decimal initialBalance)
        {
            Balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Số dư ban đầu phải lớn hơn hoặc bằng 0");
        }

        public virtual void Deposit(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"Gửi thành công {money}. Số dư hiện tại: {Balance}");
            }
            else
            {
                Console.WriteLine("Số tiền gửi không hợp lệ.");
            }
        }

        public virtual void WithDraw(decimal money)
        {
            if (money > 0 && money <= Balance)
            {
                Balance -= money;
                Console.WriteLine($"Rút thành công {money}. Số dư hiện tại: {Balance}");
            }
            else
            {
                Console.WriteLine("Số tiền rút không hợp lệ.");
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }

}
