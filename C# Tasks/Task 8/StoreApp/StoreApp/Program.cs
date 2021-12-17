using System;

namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************** HELLO! ****************************************************\n");
            Milk[] DataBase = new Milk[0];
            int Id = 0;
            while (true)
            {
                Console.WriteLine("\n                                         Emeliyyatin ID-sini daxil edin  ");
                Console.WriteLine("________________________________________________________________________________________________________________\n");
                Console.WriteLine("1.Dahhboard        2.Mehsul elave etmek        3.Mehsul satmaq        4.Mehsul silmek        5.Proqrami baglamaq");
                Console.WriteLine("________________________________________________________________________________________________________________\n");
                CWArrow();
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        DashBoard(DataBase);
                        break;
                    case 2:
                        AddProduct(ref DataBase, ref Id);
                        break;
                    case 3:
                        SellProduct(ref DataBase);
                        break;
                    case 4:
                        RemoveProduct(ref DataBase);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("ERROR! : ID-ni sehv daxil etdiniz...");
                        break;
                }
            }

        }

        static void DashBoard(Milk[] Db)
        {
            if (Db.Length != 0)
            {
                Console.WriteLine("");
                foreach (var item in Db)
                {
                    Console.WriteLine($"{item.Id}. {item.Name}   {item.Volume}L  {item.Price} {item.Valuta}   {item.Count}   {item.TotalIncome}");
                }
            }
            else
            {
                Console.WriteLine("\nERROR! : Baza yaradilmayib\n");
            }
        }

        static void AddProduct(ref Milk[] Db, ref int id)
        {
            id = Db.Length;
            while (true)
            {
                Console.WriteLine("\nMehsulun adini daxil edin : ");
                CWArrow();
                string name = Console.ReadLine();
                while (Array.Exists(Db, elem => elem.Name == name) || name.Length < 3)
                {
                    if (name.Length < 3)
                    {
                        Console.WriteLine("\nERROR! : Mehsulun adi 3 herfden cox olmalidir\n");
                    }
                    else
                    {
                        Console.WriteLine("\nERROR! : Mehsul bazada movcuddur\n");
                    }
                    Console.WriteLine("Yeniden daxil edin : ");
                    CWArrow();
                    name = Console.ReadLine();
                }
                Console.WriteLine("\nMehsulun litrini daxil edin : ");
                CWArrow();
                double volume = double.Parse(Console.ReadLine());
                while (volume < 0 || volume > 10)
                {
                    Console.WriteLine("\nERROR! : Mehsulun litri 0 ve 10 litr arasinda olmalidir\n");
                    Console.WriteLine("Yeniden daxil edin : ");
                    CWArrow();
                    volume = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nMehsulun qiymetini daxil edin : ");
                CWArrow();
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("\nMehsulun valyutasini daxil edin : ");
                CWArrow();
                string valuta = Console.ReadLine();
                Console.WriteLine("\nMehsulun sayini daxil edin : ");
                CWArrow();
                int count = int.Parse(Console.ReadLine());
                Array.Resize(ref Db, Db.Length + 1);
                Milk newMilk = new Milk(name)
                {
                    Id = id + 1,
                    Volume = volume,
                    Price = price,
                    Valuta = valuta,
                    Count = count
                };
                Db[id] = newMilk;
                id++;

                Console.WriteLine("\nBasqa Mehsul elave etmek isteyirsiniz ? Y/N\n");
                CWArrow();
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.WriteLine("\n\nSUCCES! : Mehsullar bazaya qeyd olundu\n");
                    break;
                }
                Console.WriteLine("");
            }

        }

        static void RemoveProduct(ref Milk[] Db)
        {
            DashBoard(Db);
            Console.WriteLine("\nSilmek istediyiniz mehsulun Id-ni daxil edin : ");
            CWArrow();
            int id = int.Parse(Console.ReadLine());
            Db = Array.FindAll(Db, elem => elem.Id != id);
            Console.WriteLine("\nSucces! : Mehsul bazadan silindi\n");
            id = 1;
            foreach (var item in Db)
            {
                item.Id = id;
                id++;
            }
        }

        static void SellProduct(ref Milk[] Db)
        {
            DashBoard(Db);
            Console.WriteLine("\nSatmaq istediyiniz mehsulun Id-ni daxil edin : ");
            CWArrow();
            int id = int.Parse(Console.ReadLine());
            if (Db[id - 1].Count != 0)
            {
                Console.WriteLine("Satisin sayini daxil edin : ");
                CWArrow();
                int sellCount = int.Parse(Console.ReadLine());

                foreach (var item in Db)
                {
                    if (item.Id == id)
                    {
                        if (item.Count >= sellCount)
                        {
                            item.Count = item.Count - sellCount;
                            item.TotalIncome = item.TotalIncome + (item.Price * sellCount);
                            Console.WriteLine("\nSUCCES : Mehsul ugurla satilmisdir\n");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nERROR! : Saymaq istediyiniz mehsul stokda yoxdur\n");
            }
        }

        static void CWArrow()
        {
            Console.Write(">>");
        }
    }

}
