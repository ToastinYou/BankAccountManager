namespace Bank
{
    internal class Person
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string dob { get; private set; }
        public string dlNum { get; private set; }
        public List<Account> accounts { get; private set; }

        public Person(string firstName, string lastName, string dob, string dlNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.dlNum = dlNum;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void TransferAcct(string acctNum)
        {
            foreach (var account in Start.masterAccounts)
            {
                if (account.GetAcctNum() == acctNum)
                {
                    account.SetPerson(this);
                    break;
                }
            }

            Console.WriteLine($"Account #{acctNum} is now owned by {firstName} {lastName}.");
        }

        // this probably is not needed... Account obj requires a Person obj, so why would we have an Account obj with no Person obj attached?
        //public void AddAcct(string acctNum)
        //{
        //    foreach (var account in accounts)
        //    {
        //        if (account.GetAcctNum() == acctNum)
        //        {
        //            Console.WriteLine($"{firstName} {lastName} already owns Account #{acctNum}.");
        //            return;
        //        }
        //    }

        //    accounts.Add(acctNum);
        //    Console.WriteLine($"Account #{acctNum} is now owned by {firstName} {lastName}.");
        //}

        // necessary?? why would no one own the account? .. should be closed if no one owns it
        //public void RemoveAcct(string acctNum)
        //{
        //    foreach (var account in accounts)
        //    {
        //        if (account.GetAcctNum() == acctNum)
        //        {
        //            Console.WriteLine($"Account #{acctNum} removed from {firstName} {lastName}.");
        //            return;
        //        }
        //    }

        //    Console.WriteLine($"{firstName} {lastName} does not own Account #{acctNum}.");
        //}
    }
}
