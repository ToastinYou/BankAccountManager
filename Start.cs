namespace Bank
{
    internal class Start
    {
        internal static string routingNum = "1";
        internal static List<Account> masterAccounts = new List<Account>();
        internal static List<Person> masterPersons = new List<Person>();

        private static void Main()
        {
            Console.WriteLine("Welcome to Logistics Banking: Mobile Banking Reimagined");
            RequestCmd();
        }

        private static void RequestCmd()
        {
            Console.WriteLine("What would you like to do today?");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "new":
                    NewPerson();
                    break;
                case "open":
                    OpenAccount();
                    break;
                case "help":
                    Console.WriteLine("Requesting help..");
                    break;
                case "close":
                    Console.WriteLine("Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid command, try again..");
                    break;
            }

            RequestCmd();
        }

        private static void NewPerson()
        {
            Console.WriteLine("Enter first name.");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter last name.");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter date of birth.");
            var dob = Console.ReadLine();

            Console.WriteLine("Enter driver's license number.");
            var dlNum = Console.ReadLine();

            // TODO: safety net for nullable objs
            Person p = new Person(firstName, lastName, dob, dlNum);

            Console.WriteLine($"Account opened with the following information: {firstName} | {lastName} | {dob} | {dlNum}.");
        }

        private static void OpenAccount()
        {
            Console.WriteLine("Initial deposit amount:");
            var balance = int.Parse(Console.ReadLine());
            Account a = new Account(null, balance, Account.AccountType.Checking);
        }
    }
}