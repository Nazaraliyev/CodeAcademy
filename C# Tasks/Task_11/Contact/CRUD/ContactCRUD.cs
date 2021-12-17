using AddressBook.Component;
using AddressBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.CRUD
{
    class ContactCRUD : IContact<Contact>
    {
        List<Contact> AddresBook = new List<Contact>();
        public void NewContact(Contact newcontact)
        {
            AddresBook.Add(newcontact);
        }

        public void UpdateContact(int id, Contact UpdatedContact)
        {
            int index = AddresBook.FindIndex(0,AddresBook.Count, elem => elem.Id == id);
            AddresBook[index] = UpdatedContact;
            Console.WriteLine("\nSucces : Contact updated\n");
        }

        public void DeleteContact(int id)
        {
            Contact FoundContact = FindContact(id);
            AddresBook.Remove(FoundContact);
            Console.WriteLine("\nSucces : Contact deleted\n\n");
        }

        public Contact FindContact(int id)
        {
            Contact FoundedContact = AddresBook.Find(elem => elem.Id == id);
            return FoundedContact;
        }

        public bool ReadAll()
        {
            if (AddresBook.Count != 0)
            {
                Console.WriteLine("\n\n" +
                    "Id".PadRight(5) +
                    "Name".PadRight(15) +
                    "Surname".PadRight(20) +
                    "Number".PadRight(15) +
                    "Adress"
                );
                Console.WriteLine("__________________________________________________________________________\n");
                foreach (var contact in AddresBook)
                {
                    Console.Write(contact.Id.ToString().PadRight(5));
                    Console.Write(contact.Name.PadRight(15));
                    Console.Write(contact.Surname.PadRight(20));
                    Console.Write(contact.Number.ToString().PadRight(15));
                    Console.WriteLine(contact.Adress);
                }
                return true;
            }
            else
            {
                Console.WriteLine("\nError! : DataBase id not found\n");
                return false;
            }
        }
    }
}
