using System;
using MyLinq;

namespace CA_Work_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 2, 4, 5, 7, 1, 10, 8 };
            Console.Write("[ ");
            foreach (var item in Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine("\nArrayin maksimumu : " + Linq.Maks(Arr));
            Console.WriteLine("Arratin minimumu : " +Linq.Min(Arr));
            Console.WriteLine("Arraydaki ededlerin cemi :" + Linq.Sum(Arr));
        }
    }
}
