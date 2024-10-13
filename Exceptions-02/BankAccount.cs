using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_02
{
    internal class BankAccount
    {
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot deposit a negative amount");
            }

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Cannot widthdraw a negative amount");
            }

            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("amount", "Cannot withdraw an amount bigger then the existing balance");
            }

            Balance -= amount;
        }
    }
}
