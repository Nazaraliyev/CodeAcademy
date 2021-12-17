using AddressBook.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Component
{
    class ContactServices
    {

        static ContactCRUD Crud = new ContactCRUD();
        static int ContactId = 1;
        public static void AddNewContactService()
        {
            bool choise = true;
            do
            {
                Console.WriteLine("Please enter Contact Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("\nPlease enter Contact Surname : ");
                string surname = Console.ReadLine();
                Console.WriteLine("\nPlease enter Contact Number : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPlease enter Contact Addres : ");
                string addres = Console.ReadLine();
                Contact newContact = new Contact()
                {
                    Id = ContactId,
                    Name = name,
                    Surname = surname,
                    Number = number,
                    Adress = addres
                };
                Crud.NewContact(newContact);
                Console.WriteLine("\nSucces : New Contact added to Database\n");
                ContactId++;
                Console.WriteLine("Do you want add other contact?  yes/no");
                while (true) {
                    string loopchoise = Console.ReadLine();
                    if (loopchoise == "yes" || loopchoise == "Yes" || loopchoise == "YES") break;
                    else if (loopchoise == "no" || loopchoise == "No" || loopchoise == "NO")
                    {
                        choise = false;
                        break;
                    }
                    else Console.WriteLine("\nError : Choise is not correct\n\nEnter Again");
                }
                Console.WriteLine();

            } while (choise);
        }
        public static void UpdateContactService()
        {
            if (Crud.ReadAll())
            {
                Console.WriteLine("\n\nEnter Id of Contact that would you update");
                int id = int.Parse(Console.ReadLine());
                Contact FindContact = Crud.FindContact(id);
                Console.WriteLine($"Enter Updated name ({FindContact.Name}): ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter Updated surname ({FindContact.Surname}): ");
                string surname = Console.ReadLine();
                Console.WriteLine($"Enter Updated number ({FindContact.Number}): ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter Updated addres ({FindContact.Adress}): ");
                string addres = Console.ReadLine();
                Contact UpdateContact = new Contact()
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    Number = number,
                    Adress = addres
                };
                Crud.UpdateContact(id, UpdateContact);
            }

        }
        public static void DeleteContactService()
        {
            if (Crud.ReadAll())
            {
                Console.WriteLine("Enter id of Contact that would you delete : ");
                int id = int.Parse(Console.ReadLine());
                Crud.DeleteContact(id);
            };
        }
        public static void ReadAllServices()
        {
            Crud.ReadAll();
        }
    }
}
