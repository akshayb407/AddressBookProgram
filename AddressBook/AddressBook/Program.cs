using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book\n");
 
            Console.WriteLine("Welcome to Address Book\n");
            UC1CreateContact uc1 = new UC1CreateContact();

            uc1.CreateContact();


            Console.WriteLine("UC2 starting");
            UC2AddNewContacts uc2 = new UC2AddNewContacts();
            uc2.AddNewContacts();

            Console.WriteLine("UC3 starting");
            UC3UpdateExistingContact uc3 = new UC3UpdateExistingContact();
            uc3.UpdateContact();

        }
    }
}
