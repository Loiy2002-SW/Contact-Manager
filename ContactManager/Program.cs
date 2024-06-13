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
            contacts.Remove(contact);
            return contacts;
        }

        //View All Contacts method
        public static List<string> ViewAllContacts()
        {
            return contacts;
        }
    }
}
