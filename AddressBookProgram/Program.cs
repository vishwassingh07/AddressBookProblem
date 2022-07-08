using System;
namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Program ");
            AddressBook addressBook = new AddressBook();
            addressBook.GetContact();
            addressBook.ListContact();


        }
    }
}