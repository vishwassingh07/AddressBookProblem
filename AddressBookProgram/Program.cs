using System;
namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Program ");
            AddressBook addressBook = new AddressBook();
            bool end = true;
            Console.WriteLine("1. Add Contact\n2. Edit Contact\n3. Delete Contact\n4. End Program");
            while (end == true)
            {
                Console.WriteLine("Choose Option To Execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.GetContact();
                        addressBook.ListContact();
                        break;
                    case 2:
                        addressBook.GetContact();
                        addressBook.EditContact();
                        addressBook.ListContact();
                        break;
                    case 3:
                        addressBook.GetContact();
                        addressBook.DeletePeople();
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}