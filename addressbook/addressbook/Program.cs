using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program!");
            ContactDetails createContacts = new ContactDetails();
            createContacts.Contacts();
        }
    }
}
