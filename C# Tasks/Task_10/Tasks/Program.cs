using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        #region Task 1
        //static void Main(string[] args)
        //{
        //List<int> IntegerNumbers = new List<int>(){1,2,4,6,12};
        //for (int i = 0; i < IntegerNumbers.Count; i++)
        //{
        //    IntegerNumbers[i] = IntegerNumbers[i] * 3;
        //}
        //}

        #endregion

        #region Task 2
        //static void Main(string[] args)
        //{
        //    List<int> IntegerNumbers = new List<int>() { 1, 2, 4, 6, 12 };
        //    for (int i = 0; i < IntegerNumbers.Count; i++)
        //    {
        //        IntegerNumbers[i] = (int)Math.Pow(IntegerNumbers[i], 3);
        //    }
        //}
        #endregion

        #region Task 3
        //static void Main(string[] args)
        //{
        //    List<string> StringList = new List<string>() { "A", "B", "C" };
        //    for (int i = 0; i < StringList.Count; i++)
        //    {
        //        StringList[i] = StringList[i].PadLeft(2, '#').PadRight(3, '#');
        //    }
        //}
        #endregion

        #region Task 4
        //static void Main(string[] args)
        //{
        //    Car Mercedes = new Car() { Brand = "Mercedes", Model = "SlS", DoorCount = 2 };
        //    Car Porsche = new Car() { Brand = "Porsche", Model = "GT3", DoorCount = 2 };
        //    Car Dodge = new Car() { Brand = "Dodge", Model = "Challenger", DoorCount = 2 };
        //    Car Chevrolet = new Car() { Brand = "Chevrolet", Model = "Camaro", DoorCount = 2 };
        //    Car Tesla = new Car() { Brand = "Tesla", Model = "Model 3", DoorCount = 4 };

        //    List<Car> Cars = new List<Car>() { Mercedes, Porsche, Dodge, Chevrolet, Tesla };

        //    foreach (var item in Cars)
        //    {
        //        item.ShowInfo();
        //    }

        //}
        //class Car
        //{
        //    public string Brand { get; set; }
        //    public string Model { get; set; }
        //    public int DoorCount { get; set; }
        //    public void ShowInfo()
        //    {
        //        Console.WriteLine($"{Brand}  {Model}  {DoorCount}");
        //    }
        //}

        #endregion

        #region Task 5
        //static void Main(string[] args)
        //{
        //    List<byte> Ages = new List<byte>();
        //    List<byte> oldAges = new List<byte>() { 65, 53, 23, 46, 34};

        //    Ages.Add(12);
        //    Ages.AddRange(oldAges);


        //    //Ages.Remove(65);
        //    //Ages.RemoveAt(2);
        //    //Ages.RemoveRange(0, 2);
        //    //Ages.RemoveAll(elem => elem > 50);
        //    //Ages = Ages.FindAll(elem => elem > 40);
        //    //Ages.Clear();


        //    foreach (var item in Ages) Console.WriteLine(item);
        //}
        #endregion

        #region Task 6
        public delegate void MyDelegate(int a, int b); // burda Return type-ni void eledim ki Task uzanmasin, Qiymetimi kesmememyiniz dileyi ile :D
                                                       // Eger int mecburi olsa yazb gondere bilerem yeniden 8/
        static void Main(string [] args)
        {
            MyDelegate GeneralOperation = new MyDelegate(Sum);
            GeneralOperation += Subtraction;
            GeneralOperation += Divicion;
            GeneralOperation += Multiplication;

            GeneralOperation(10, 20);
        }

        static void Sum(int a, int b) {
            Console.WriteLine($" Sum : {a + b}");
        }

        static void Subtraction(int a, int b) {
            Console.WriteLine($" Subtraction : {a - b}");
        }
        static void Divicion(int a, int b) {
            Console.WriteLine($" Divicion : {(double)a / b}");
        }
        static void Multiplication(int a, int b) {
            Console.WriteLine($" Multiplication : {a * b}");
        }
        #endregion
    }
}
