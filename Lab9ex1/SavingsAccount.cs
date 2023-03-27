namespace Lab9ex1
{
    class SavingsAccount : BankAccount
    {
        private readonly decimal interestRate;

        public SavingsAccount(decimal interestRate)
        {
            this.interestRate = interestRate;
        }
        public override void DepositCash(decimal val)
        {
            base.DepositCash(val);
            balance *= (1 + interestRate);
        }

        public override string ToString()
        {
            return $"Savings account {base.ToString()}, interest rate {interestRate}";
        }
    }
}
