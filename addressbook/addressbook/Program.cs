using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Address Book Program!");
            //ContactDetails createContacts = new ContactDetails();
            //createContacts.Contacts();

            //Console.WriteLine("Add New Contacts Program");
            //AddNewContacts addNewCon = new AddNewContacts();
            //addNewCon.addNewContacts();

            //Console.WriteLine("Update Existing Contact Program");
            //UpdateExistingContact update = new UpdateExistingContact();
            //update.UpdateContact();

            Console.WriteLine("Delete a Contact Program");
            DeleteContact deleteContact = new DeleteContact();
            deleteContact.ContactDelete();
            Console.ReadKey();
        }
    }
}
