﻿using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to Address Book\n");
            UC1CreateContact uc1 = new UC1CreateContact();
            uc1.CreateContact();



        }
    }
}
