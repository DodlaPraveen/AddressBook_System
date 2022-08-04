using System;
using System.Collections.Generic;
using System.Text;

namespace addressbook
{
    class AddNewContacts
    {
        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();

        // method for add new contact
        public void addNewContacts()
        {

            CreateContact(addressBook);
        }


        // method for creating contact in address book
        public void CreateContact(List<string> addressBook)
        {
            int count = 0;
            string contact;
            char ch;
            do
            {
                Console.WriteLine("\nPlease Enter Contact Details: \n");
                ContactDeatils();
                Console.WriteLine("\nContact Created.\n");

                contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                addressBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue: y/n");
                ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            }
            while (ch == 'y');


            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i + 1, addressBook[i]);
            }
            toContinue();
        }

        // method for taking user input from console for creating or updating a contact
        public void ContactDeatils()
        {

            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            email = Console.ReadLine(); ;
            Console.Write("Address : ");
            address = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("State : ");
            state = Console.ReadLine();
            Console.Write("Zip : ");
            zipCode = Convert.ToInt32(Console.ReadLine());
        }



        public void toContinue()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            char ch;
            Console.WriteLine("Do you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n\n");
            if (ch == 'y')
            {
                addNewContacts();

                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
