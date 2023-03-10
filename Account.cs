namespace Bank
{
    internal class Account
    {
        private Person person { get; set; }
        private string acctNum = string.Empty;
        private int balance = 0;
        private AccountType accountType;

        private const int minBal = 25;

        public enum AccountType
        {
            Checking,
            Saving
        }

        public Account(Person person, int balance, AccountType accountType)
        {
            if (!MinBal(balance))
            {
                Console.WriteLine($"Sorry, you must have an initial deposit of at least ${minBal} before you can open this type of account.");
                return;
            }

            this.person = person;
            SetAcctNum();
            this.balance = balance;
            this.accountType = accountType;
        }

        private void SetAcctNum()
        {
            this.acctNum = new Random().Next().ToString();
        }

        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        private bool MinBal(int bal) => bal >= minBal;
    }
}