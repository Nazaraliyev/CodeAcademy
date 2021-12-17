using Store.Component;
using Store.CRUD;
using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            NotebookStore NotebooksStore = new NotebookStore();
            bool choise = true;
            Console.WriteLine("======================================================  Hello  ======================================================");
            while (choise)
            {
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("\n1. Mehsul elave et           2. Mehsullara bax           3.Mehsulu update et           4. Mehsul sil           5. Cix");
                Console.WriteLine("_____________________________________________________________________________________________________________________\n");
                byte chose = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (chose)
                {
                    case 1:
                        Create(NotebooksStore);
                        Console.WriteLine("\n\n");
                        break;
                    case 2:
                        NotebooksStore.GetNotebook();
                        Console.WriteLine("\n\n");
                        break;
                    case 3:
                        if (NotebooksStore.GetNotebook())
                        {
                            Console.WriteLine("\nUpdate etmek istediyiniz mehsulun adini daxil edin : ");
                            string UpdateProductName = Console.ReadLine();
                            Notebook oldNotebook = NotebooksStore.notebooks.Find(elem => elem.Name == UpdateProductName);
                            Notebook newNotebook = Update(NotebooksStore, oldNotebook);
                            NotebooksStore.UpdateNotebook(newNotebook, UpdateProductName);
                        }
                        Console.WriteLine("\n\n");
                        break;
                    case 4:
                        if (NotebooksStore.GetNotebook())
                        {
                            NotebooksStore.DeleteNotebook();
                        }
                        Console.WriteLine("\n\n");
                        break;
                    case 5:
                        choise = false;
                        break;
                    default:
                        Console.WriteLine("!ERROR : Secim sehvdir");
                        Console.WriteLine("\n\n");
                        break;
                }
            }

        }
        static void Create(NotebookStore notebooksStore)
        {

            bool WhileMain = true;
            while (WhileMain)
            {
                Console.WriteLine("Notebook Brendini daxil edin : ");
                string brand = Console.ReadLine();
                Console.WriteLine("\nNotebook modeli daxil edin : ");
                string model = Console.ReadLine();
                Console.WriteLine("\nNotebook adini daxil edin : ");
                string name = Console.ReadLine();
                while (!notebooksStore.notebooks.TrueForAll(elem => elem.Name != name))
                {
                    Console.WriteLine("\nERROR! : Bu mehsul bazada movcuddur\n");
                    Console.WriteLine("Notebookun adini yenden daxil edin : ");
                    name = Console.ReadLine();
                }
                Console.WriteLine("\nNotebookun ramini daxil edin : ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nNotebookun yaddasini daxil edin : ");
                int storage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nNotebookun sayini daxil edin : ");
                int stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nNotebookun qiymetini daxil edin : ");
                double price = Convert.ToInt32(Console.ReadLine());
                Notebook newNotebook = new Notebook()
                {
                    Name = name,
                    Model = model,
                    Brand = brand,
                    Ram = ram,
                    Storage = storage,
                    InStock = stock,
                    Price = price
                };
                notebooksStore.AddNotebook(newNotebook);
                Console.WriteLine();
                newNotebook.ShowInfo();
                Console.WriteLine("\nSUCCES : Mehsul bazaya daxil olundu\n");
                while (true)
                {
                    if (notebooksStore.Limit != 0)
                    {
                        Console.WriteLine("Devam edek  (yes/no) : ");
                        string ope = Console.ReadLine();
                        if (ope == "No" || ope == "no")
                        {
                            WhileMain = false;
                            break;
                        }
                        else if (ope == "yes" || ope == "Yes")
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nERROR! : Secim sehvdir\n");
                            Console.WriteLine("Yeniden daxil edin\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nLimit doldu, Tesekkurler!\n");
                        WhileMain = false;
                        break;
                    }
                }
            }
        }

        public static Notebook Update(NotebookStore notebooksStore, Notebook oldNotebook)
        {
            Console.WriteLine($"Notebook Brendini daxil edin ({oldNotebook.Brand}) : ");
            string brand = Console.ReadLine();
            Console.WriteLine($"\nNotebook modeli daxil edin ({oldNotebook.Model}) : ");
            string model = Console.ReadLine();
            Console.WriteLine($"\nNotebook adini daxil edin ({oldNotebook.Name}) : ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nNotebookun ramini daxil edin ({oldNotebook.Ram}) : ");
            int ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nNotebookun yaddasini daxil edin ({oldNotebook.Storage}) : ");
            int storage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nNotebookun sayini daxil edin ({oldNotebook.InStock}) : ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nNotebookun qiymetini daxil edin ({oldNotebook.Price}) : ");
            double price = Convert.ToInt32(Console.ReadLine());
            Notebook newNotebook = new Notebook()
            {
                Name = name,
                Model = model,
                Brand = brand,
                Ram = ram,
                Storage = storage,
                InStock = stock,
                Price = price
            };
            return newNotebook;
        }
    }
}
