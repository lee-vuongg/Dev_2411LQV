using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4._1
{
    public class SavingAccount : Account
    {
        private decimal Rate;

        public SavingAccount(decimal initialBalance, decimal rate) : base(initialBalance)
        {
            Rate = rate;
        }

        public decimal GetInterest()
        {
            return Balance * Rate;
        }
    }
}
