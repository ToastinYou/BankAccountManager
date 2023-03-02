namespace Bank
{
    internal class Person
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string dob { get; private set; }
        public string dlNum { get; private set; }
        public List<string> acctNums { get; private set; }

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

        public void AddAcct(string acctNum)
        {
            if (acctNums.Contains(acctNum))
            {
                Console.WriteLine($"{firstName} {lastName} already owns Account #{acctNum}.");
                return;
            }

            //xfer ownership??

            acctNums.Add(acctNum);
            Console.WriteLine($"Account #{acctNum} is now owned by {firstName} {lastName}.");
        }

        public void RemoveAcct(string acctNum)
        {
            if (!acctNums.Remove(acctNum))
            {
                Console.WriteLine($"{firstName} {lastName} does not own Account #{acctNum}.");
                return;
            }

            Console.WriteLine($"Account #{acctNum} removed from {firstName} {lastName}.");
        }
    }
}
