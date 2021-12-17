using Store.Component;
using Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.CRUD
{
    class NotebookStore : IMarket
    {
        public int Limit = 3;
        //public Notebook[] notebooks = new Notebook[0];
        public List<Notebook> notebooks = new List<Notebook>();
        public void AddNotebook(Notebook newNB)
        {
            if (Limit != 0)
            {
                //Array.Resize(ref notebooks, notebooks.Length + 1);
                //notebooks[notebooks.Length - 1] = newNB;
                notebooks.Add(newNB);
                Limit--;
            }
        }

        public bool GetNotebook()
        {
            if(notebooks.Count != 0)
            {
                Console.WriteLine("\n\n" +
                    "   Name".PadRight(18) +
                    "Brand".PadRight(15) +
                    "Model".PadRight(15) +
                    "Ram".PadRight(10) +
                    "Storage".PadRight(10) +
                    "Price".PadRight(10) +
                    "Stock".PadRight(10)
                );
                Console.WriteLine("   ________________________________________________________________________________\n");
                int number = 1;
                foreach (var item in notebooks)
                {
                    Console.WriteLine(
                        number + ". " +
                        item.Name.PadRight(15) +
                        item.Brand.PadRight(15) +
                        item.Model.PadRight(15) +
                        item.Ram.ToString().PadRight(10) +
                        item.Storage.ToString().PadRight(10) +
                        item.Price.ToString().PadRight(10) +
                        item.InStock.ToString().PadRight(10)
                    );
                    number++;
                }
                return true;
            }
            else
            {
                Console.WriteLine("\nERROR! : Baza yaradilmayib!\n");
                return false;
            }
            
        }

        public void UpdateNotebook(Notebook notebook, string UpdateProductName)
        {
            int index = notebooks.FindIndex(elem => elem.Name == UpdateProductName);
            notebooks[index] = notebook;
            Console.WriteLine("\nMehsul update olundu\n");
        }

        public void DeleteNotebook()
        {
            Console.WriteLine("\nSilmek istediyiniz mehsulun adini daxil edin : ");
            string DeleteProductName = Console.ReadLine();
            Console.WriteLine("\n\n");

            notebooks = notebooks.FindAll(elem => elem.Name != DeleteProductName);
            Console.WriteLine("\nMehsul bazadan silindi\n");
        }

    }
}
