using System.Text.RegularExpressions;

namespace ContactManager
{
    public class Program
    {
        public static List<string> contacts = new List<string>();

        static void Main(string[] args)
        {

            ContactsManager();

        }


        //Console (READ & WRITE)
        public static void ContactsManager()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("====================================\n");
            Console.WriteLine("Welcome to the Contacts maneger app\n");
            Console.WriteLine("====================================\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose what you want to do: \n 1 = Add Contact. \n 2 = Remove Contact. \n 3 = View Contacts.");

            ChooseOperation();
            
        }


        //Add contact if it is not in the list
        public static List<string> AddContact(string contact)
        {
            if (!contacts.Contains(contact))
            {
                contacts.Add(contact);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{contact} is successfully added to contacts.");
            }
            else {

                //this was only for Xunit testing
                //throw new ArgumentException("Contact already exists.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The contact is already exists!");
                

            }

            return contacts;
        }

        //Remove contact if it is already in the list
        public static List<string> RemoveContact(string contact)
        {
            if (contacts.Contains(contact)) {

                contacts.Remove(contact);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{contact} is successfully removed from.");
            }
            else
            {
                //this was only for Xunit testing
                //throw new ArgumentException("Contact doesn't exist.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[{contact}] is not in the contacts list.");

            }
            return contacts;
        }

        //View All Contacts method
        public static List<string> ViewAllContacts()
        {
            if (contacts.Count > 0)
            {
                return contacts;
            }
            else {

                //this was only for Xunit testing
                //throw new ArgumentException("There are no conatacts.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("The contact list is empty, choose option 1 to add some....");
                return contacts;
               

            }
        }



        //---------------------------------- Helping methods ----------------------------------
        private static void ChooseOperation()
        {
            bool isRightAnswer = false;
            string answer = "No answer yet";

            while (!isRightAnswer)
            {
                answer = Console.ReadLine();

                if (answer == "1" || answer == "2" || answer == "3")
                    isRightAnswer = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose a correct number (1, 2 or 3)");
                }

            }

            switch (answer)
            {
                case "1":
                    AskForContactNameToBeAdded();
                    AskIfTheUserWantToDoAnotherOperation();
                    break;

                case "2":
                    AskForContactNameToBeRemoved();
                    AskIfTheUserWantToDoAnotherOperation();
                    break;

                case "3":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[{String.Join(", ", ViewAllContacts())}]\n");
                    AskIfTheUserWantToDoAnotherOperation();
                    break;

            }
        }

        private static void AskIfTheUserWantToDoAnotherOperation()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to make another operation? (y/n)");

            bool isValidAnswer = false;
            string answer = "no answer";


            while (!isValidAnswer)
            {
                answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choose what you want to do: \n 1 = Add Contact. \n 2 = Remove Contact. \n 3 = View Contacts.\n");
                    ChooseOperation();
                    isValidAnswer = true;
                }

                else if (answer.ToLower() == "n")
                {
                    isValidAnswer = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid value (y or n)");
                }
            }

        }

        private static void AskForContactNameToBeAdded()
        {

            bool isValidName = false;
            string name = "";


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the contact name: ");

            while (!isValidName)
            {
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || Regex.IsMatch(name, @"\d"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid name (minimum length 2 and no numbers):");
                }

                else
                    isValidName = true;
            }

            AddContact(name);

        }

        private static void AskForContactNameToBeRemoved()
        {

            bool isValidName = false;
            string name = "";


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the contact name: ");

            while (!isValidName)
            {
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || Regex.IsMatch(name, @"\d"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter a valid name (minimum length 2 and no numbers):");
                }

                else
                    isValidName = true;
               
            }

            RemoveContact(name);

        }


    }
}
