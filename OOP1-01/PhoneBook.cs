using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba1
{
    internal class PhoneBook
    {
        private List<Contact> ContactList { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }

        public void PrintAll()
        {
            foreach (Contact contact in ContactList)
            {
                if (contact.PhoneNumber == "")
                {
                    continue;
                }

                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.PhoneNumber}");
            }
        }

    }
}
