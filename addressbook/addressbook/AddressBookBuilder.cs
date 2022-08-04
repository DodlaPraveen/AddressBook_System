using System;
using System.Collections.Generic;
using System.Text;

namespace addressbook
{
    class AddressBookBuilder : IContacts
    {
        public Dictionary<string, Contacts> dictionary;
        public AddressBookBuilder()
        {
            this.dictionary = new Dictionary<string, Contacts>();
        }
        public void addContact()
        {
            string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
            Console.WriteLine("Enter First Name : ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            State = Console.ReadLine();
            Console.WriteLine("Enter Zip code : ");
            Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            Contacts contact = new Contacts(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
            dictionary.Add(FirstName, contact);
        }
        public void displayContacts()
        {
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                Console.WriteLine("First Name : " + dict.Value.firstName);
                Console.WriteLine("Last Name : " + dict.Value.lastName);
                Console.WriteLine("Address : " + dict.Value.address);
                Console.WriteLine("City : " + dict.Value.city);
                Console.WriteLine("State : " + dict.Value.state);
                Console.WriteLine("Zip : " + dict.Value.zip);
                Console.WriteLine("Phone Number : " + dict.Value.phoneNo);
                Console.WriteLine("Email : " + dict.Value.email);
            }
        }
        public void editContact(string firstName)
        {
            int found = 0;
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                if (firstName.Equals(dict.Key))
                {
                    found = 1;
                    Console.WriteLine("Enter Last Name : ");
                    dict.Value.lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    dict.Value.address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    dict.Value.city = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    dict.Value.state = Console.ReadLine();
                    Console.WriteLine("Enter Zip code : ");
                    dict.Value.zip = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    dict.Value.phoneNo = Console.ReadLine();
                    Console.WriteLine("Enter Email : ");
                    dict.Value.email = Console.ReadLine();
                }
            }
            if (found == 0)
            {
                Console.WriteLine("No Contacts matched with given first name");
            }
        }
        public void deleteContact(string firstName)
        {
            int found = 0;
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                if (firstName.Equals(dict.Key))
                {
                    dictionary.Remove(firstName);
                    found = 1;
                    Console.WriteLine("Contact deleted");
                }
            }
            if (found == 0)
            {
                Console.WriteLine("No Contacts matched with given first name");
            }
        }
    }
}
