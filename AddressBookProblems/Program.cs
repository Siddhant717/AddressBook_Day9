using System;

namespace AddressBookProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addnewcontact = new AddressBookMain();
            addnewcontact.AddNewContacts();
            addnewcontact.Display();
        }
    }
}
