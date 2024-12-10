using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAP4._1
{
    public class Account
    {
        protected decimal Balance;

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Số tiền gửi phải lớn hơn 0.");
                return;
            }
            Balance += money;
            Console.WriteLine($"Đã gửi {money}. Số dư hiện tại: {Balance}.");
        }

        public virtual void WithDraw(decimal money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0.");
                return;
            }
            if (money > Balance)
            {
                Console.WriteLine("Số dư không đủ để rút.");
                return;
            }
            Balance -= money;
            Console.WriteLine($"Đã rút {money}. Số dư hiện tại: {Balance}.");
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }

}
