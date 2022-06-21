using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Address Book AddressBook");
        }

        public static void SetContact()
        {
            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Akshay";
            addressBook.lastName = "Bhagwat";
            addressBook.address = "Pune Katrj";
            addressBook.state = "Maharashtra";
            addressBook.zip = 411046;
            addressBook.phoneNumber = 8087148746;
            addressBook.email = "akshayb407@gmail.com";

        }
        
    }
}
