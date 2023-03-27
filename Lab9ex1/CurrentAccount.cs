using System;

namespace Lab9ex1
{
    class CurrentAccount : BankAccount
    {
        private const decimal OverdraftLimit = 5000;
        public override void WithdrawCash(decimal val)
        {
            if (val <= balance + OverdraftLimit)
            {
                balance -= val;
                Console.WriteLine($"Cash amount {val} withdrawn");
            }
            base.WithdrawCash(val);
        }

        public override string ToString()
        {
            return $"Current account {base.ToString()}";
        }
    }
}
