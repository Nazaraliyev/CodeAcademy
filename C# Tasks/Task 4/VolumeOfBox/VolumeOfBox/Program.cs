using System;

namespace VolumeOfBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Volume vol = new Volume();
            Console.Write("Enter Width : ");
            vol.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length : ");
            vol.lenhtg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter heigth : ");
            vol.heigth = Convert.ToInt32(Console.ReadLine());


            static void VolumeOfBox(Volume obj)
            {
                Console.WriteLine(obj.width * obj.heigth * obj.lenhtg);
            }

            VolumeOfBox(vol);
        }

    }
    class Volume
    {
        public int width;
        public int lenhtg;
        public int heigth;
    }
}
