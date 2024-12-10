using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON4_LAP4._1
{
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
            Balance -= FeeTransfer;
            Console.WriteLine($"Đã trừ phí giao dịch {FeeTransfer}. Số dư hiện tại: {Balance}.");
        }

        public override void WithDraw(decimal money)
        {
            if (money + FeeTransfer > Balance)
            {
                Console.WriteLine("Số dư không đủ để thực hiện giao dịch.");
                return;
            }
            base.WithDraw(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Đã trừ phí giao dịch {FeeTransfer}. Số dư hiện tại: {Balance}.");
        }
    }

}
