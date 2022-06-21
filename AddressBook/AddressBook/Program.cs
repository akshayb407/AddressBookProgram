using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to Address Book\n");
            UC1_CreateContact uc1 = new UC1_CreateContact();
            uc1.CreateContact();


            Console.WriteLine("UC2 starting");
            UC2AddNewContacts uc2 = new UC2AddNewContacts();
            uc2.AddNewContacts();

            Console.WriteLine("UC3 starting");
            UC3UpdateExistingContact uc3 = new UC3UpdateExistingContact();
            uc3.UpdateContact();

            Console.WriteLine("UC4 starting");
            UC4DeleteContact uc4 = new UC4DeleteContact();
            uc4.ContactDelete();

            Console.ReadKey();


        }
    }
}
