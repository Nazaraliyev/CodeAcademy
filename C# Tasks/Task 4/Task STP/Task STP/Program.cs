using System;

namespace Task_STP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Student:Person
    {
        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
        public void Study()
        {
            Console.WriteLine("I'am studing");
        }
    }

    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'am explaining");
        }

    }

    class Person
    {
        public string name;
        public string surname;
        public int age;

        public void Great()
        {
            Console.WriteLine("Hi");
        }

        public void setAge(int age)
        {
            this.age = age;
        }

    }
}
