namespace Threads
{
    public class BankAccount
    {
        private object accountLock = new object();
        double Balance { get; set; }
        string Name { get; set; }

        public BankAccount(double balance)
        {
            this.Balance = balance;
        }

        public double Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("Not enough funds to withdraw");
                return Balance;
            }

            lock (accountLock)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine("Removed {0} and {1} left", amount, (Balance - amount));
                    Balance -= amount;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}