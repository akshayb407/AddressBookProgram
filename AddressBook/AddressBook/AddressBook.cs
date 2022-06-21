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
        public string city;
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
            addressBook.city = "Pune";
            addressBook.zip = 411046;
            addressBook.phoneNumber = 8087148746;
            addressBook.email = "akshayb407@gmail.com";

        }
        public static void SetContact(String firstName, String lastName, String address, String city, String state, long zip, long phNo)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.firstName = firstName;
            Console.WriteLine("Enter firstName");
            addressBook.firstName = Console.ReadLine();
            addressBook.lastName = lastName;
            Console.WriteLine("Enter lastName");
            addressBook.lastName =Console.ReadLine();
            addressBook.address = address;
            addressBook.city = city;
            Console.WriteLine("Enter City");
            addressBook.address=Console.ReadLine();
            addressBook.state = state;
            addressBook.zip = zip;
            addressBook.phoneNumber = phNo;
           

        }
        
       

      
    }
}
