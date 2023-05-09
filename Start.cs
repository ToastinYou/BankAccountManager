using System;

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
            string cmd = GetInput();

            switch (cmd)
            {
                case "new":
                    NewPerson();
                    break;
                case "open":
                    OpenAccount();
                    break;
                case "help":
                    Console.WriteLine("Requesting help ...");
                    break;
                case "close":
                    Console.WriteLine("Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid command, please try again ...");
                    break;
            }

            RequestCmd();
        }

        private static Person NewPerson()
        {
            Console.WriteLine("Enter first name ...");
            string firstName = GetInput();

            Console.WriteLine("Enter last name ...");
            string lastName = GetInput();

            Console.WriteLine("Enter date of birth ...");
            string dob = GetInput();

            Console.WriteLine("Enter driver's license number ...");
            string dlNum = GetInput();

            return new Person(firstName, lastName, dob, dlNum);
        }

        private static void OpenAccount()
        {
            Console.WriteLine("Initial deposit amount:");
            int balance = int.Parse(GetInput());

            Person p = NewPerson();
            Account a = new Account(p, balance, Account.AccountType.Checking);

            DebugLog($"Account opened with the following information: {p.firstName} | {p.lastName} | {p.dob} | {p.dlNum}.");
        }

        private static string GetInput()
        {
            try 
            { 
                string? input = Console.ReadLine();

                if (input != null)
                {
                    return input;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch (Exception e)
            {
                DebugLog(e.ToString());
                Console.WriteLine("Invalid input, please try again.");
                return GetInput();
            }
        }

        private static void DebugLog(string msg)
        {
            #if DEBUG
                Console.WriteLine(msg);
            #endif
        }
    }
}