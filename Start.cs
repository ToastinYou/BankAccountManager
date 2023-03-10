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
    }
}