using System;

namespace Lab9ex1
{
    abstract class BankAccount
    {
        protected decimal balance;
        private readonly Guid guid = Guid.NewGuid();
        public virtual void WithdrawCash(decimal val)
        {
            if (balance <= val)
            {
                balance -= val;
                Console.WriteLine($"{val} has been extracted from account #{guid}");
            } else
            {
                Console.WriteLine("insufficient funds");
            }
        }

        public virtual void DepositCash(decimal val)
        {
            balance += val;
            Console.WriteLine($"{val} has been deposited in the account #{guid}");
        }

        public override string ToString()
        {
            return $"Account #{guid}, current balance {balance}";
        }

    }
}
