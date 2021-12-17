using AddressBook.Component;
using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choise = true;
            Console.WriteLine("=========================================== Welcome AddressBook App ===========================================");
            do
            {
                Console.WriteLine("\n_______________________________________________________________________________________________________________\n");
                Console.WriteLine("1. Database          2. New Contact          3. Update Contact          4. Delete Contact          5. Close App");
                Console.WriteLine("_______________________________________________________________________________________________________________\n");
                byte Operation = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (Operation)
                {
                    case 1:
                        ContactServices.ReadAllServices();
                        Console.WriteLine("\n\n\n\n");
                        break;
                    case 2:
                        ContactServices.AddNewContactService();
                        Console.WriteLine("\n\n\n\n");
                        break;
                    case 3:
                        ContactServices.UpdateContactService();
                        Console.WriteLine("\n\n\n\n");
                        break;
                    case 4:
                        ContactServices.DeleteContactService();
                        Console.WriteLine("\n\n\n\n");
                        break;
                    case 5:
                        choise = false;
                        break;
                }
            } while (choise);

        }
    }
}
