using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNo;
        public string email;
        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNo, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.email = email;
        }
    }
    public interface IContacts
    {
        public void addContact();
        public void displayContacts();
        public void editContact(string firstName);
        public void deleteContact(string firstName);
    }
}
