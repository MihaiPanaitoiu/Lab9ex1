using System;

namespace Lab9ex1
{
    class InvestmentsAccount : SavingsAccount
    {
        byte withdrawalDay;
        public InvestmentsAccount(byte withdrawalDay, decimal interestRate)
            :base(interestRate)
        {
            this.withdrawalDay = withdrawalDay;
        }
        public override void WithdrawCash(decimal val)
        {
            if(DateTime.Now.Day >= withdrawalDay)
            {
                base.WithdrawCash(val);
            } else
            {
                Console.WriteLine("Too soon to withdraw");
            }
        }

        public override string ToString()
        {
            return $"Investments Account {base.ToString()}, withdrawal day {withdrawalDay}";
        }
    }
}
