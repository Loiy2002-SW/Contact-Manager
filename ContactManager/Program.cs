namespace ContactManager
{
    public class Program
    {
        public static List<string> contacts = new List<string>();

        static void Main(string[] args)
        {

        }



        //Add contact method
        public static List<string> AddContact(string contact)
        {
            if (!contacts.Contains(contact))
            {
                contacts.Add(contact);
            }
            else {

                throw new ArgumentException("Contact already exists.");

            }

            return contacts;
        }

        //Remove contact method
        public static List<string> RemoveContact(string contact)
        {
            if (contacts.Contains(contact)) {

                contacts.Remove(contact);
            }
            else
            {
                throw new ArgumentException("Contact doesn't exist.");
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
            
                throw new ArgumentException("There are no conatacts.");

            }
        }
    }
}
