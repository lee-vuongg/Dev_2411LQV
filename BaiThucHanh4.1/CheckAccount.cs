using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4._1
{
    using System;

    public class CheckAccount : Account
    {
        private decimal FeeTransfer;

        public CheckAccount(decimal initialBalance, decimal feeTransfer) : base(initialBalance)
        {
            FeeTransfer = feeTransfer;
        }

        public override void Deposit(decimal money)
        {
            base.Deposit(money);
            if (money > 0) Balance -= FeeTransfer;
            Console.WriteLine($"Phí giao dịch: {FeeTransfer}. Số dư còn lại: {Balance}");
        }

        public override void WithDraw(decimal money)
        {
            if (money + FeeTransfer <= Balance)
            {
                base.WithDraw(money);
                Balance -= FeeTransfer;
                Console.WriteLine($"Phí giao dịch: {FeeTransfer}. Số dư còn lại: {Balance}");
            }
            else
            {
                Console.WriteLine("Không đủ số dư để thực hiện giao dịch.");
            }
        }
    }

}
