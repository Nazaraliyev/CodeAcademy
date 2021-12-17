using System;

namespace CA_Work_13
{
    #region Task 1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DeathStar DS = new DeathStar();
    //        DS.FireLeaser();
    //    }
    //}

    //abstract class SpaceStation
    //{ 
    //    public abstract void FireLeaser();
    //}

    //class DeathStar : SpaceStation
    //{
    //    public override void FireLeaser()
    //    {
    //        Console.WriteLine("Pew Pew");
    //    }
    //}
    #endregion

    #region Task 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car CarSts = new Car();
    //        CarSts.Drive();
    //    }
    //}
    //class Car : IVehicle
    //{
    //    public void Drive()
    //    {
    //        Console.WriteLine("Car is Driving");
    //    }
    //}

    #endregion

    #region Task 3
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is Dog Name ? ");
            string DogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.SetName(DogName);
            Console.WriteLine("**************************");
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public string SetName(string name)
        {
            return this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }


    #endregion
}