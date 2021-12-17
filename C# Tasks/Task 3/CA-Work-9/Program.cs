using System;

namespace CA_Work_9
{
    class Program
    {
        #region Task 5
        //static void Main(string[] args)
        //{
        //    Console.Write("Ededi daxil edin : ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(DecimalToBinary(num));
        //}
        //static string DecimalToBinary(int num)
        //{
        //    string binary = "";
        //    int mod;
        //    while (num != 0 && num != 1)
        //    {
        //        mod = num % 2;
        //        num = num / 2;
        //        binary = mod + binary;
        //    }
        //    binary = num + binary;

        //    return binary;
        //}
        #endregion

        #region Task 6
        //static void Main(string[] args)
        //{
        //    Console.Write("Ededi daxil edin : ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(Cube(num));
        //}
        //static double Cube(int num)
        //{
        //    //double cube = Math.Pow(num, 3);
        //    int cube = 1;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        cube = cube * num;
        //    }
        //    return cube;
        //}
        #endregion

        #region Task 7
        //static void Main(string[] args)
        //{
        //    Console.Write("Ededi daxil edin : ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(DigitOfNumber(num));
        //}
        //static int DigitOfNumber(int num)
        //{
        //    int digits = 0;
        //    while(num != 0)
        //    {
        //        num = num / 10;
        //        digits++;
        //    }

        //    return digits;
        //}
        #endregion

        #region Task 8
        //static void Main(string[] args)
        //{
        //    Console.Write("Eded daxil edin : ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Series daxil edin : ");
        //    int series = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(calculate(num, series));
        //}

        //static int calculate(int num, int series)
        //{
        //    int len = 1;
        //    string str;
        //    int sum = 0;
        //    for (int i = 0; i < series; i++)
        //    {
        //        str = "";
        //        for (int j = 0; j < len; j++)
        //        {
        //            str = str + num;
        //        }
        //        sum = sum + Convert.ToInt32(str);
        //        len++;
        //    }
        //    return sum;
        //}


        #endregion

        #region Task 9
        //static void Main(string[] args)
        //{
        //    int digit;
        //    while (true) { 
        //        Console.Write("Tek eded daxil edin : ");
        //        digit = Convert.ToInt32(Console.ReadLine());
        //        if(digit % 2 == 1)
        //        {
        //            break;
        //        }
        //    }
        //    Console.Write("Sinvolu daxil edin");
        //    string Syn = Console.ReadLine();
        //    int degre = 1;
        //    while (degre !=0)
        //    {
        //        if (degre < (digit / 2) + 1)
        //        {
        //            for (int i = 0; i < degre; i++)
        //            {
        //                Console.Write(Syn);
        //            }
        //            Console.WriteLine();
        //            degre++;
        //        }
        //        else
        //        {
        //            for (int i = degre; i > 0; i--)
        //            {
        //                for (int j = 0; j < degre; j++)
        //                {
        //                    Console.Write(Syn);
        //                }
        //                Console.WriteLine();
        //                degre--;
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Task 10
        //static void Main(string[] args)
        //{
        //    Console.Write("String daxil edin : ");
        //    string str = Console.ReadLine();
        //    Console.WriteLine(SpaceCounter(str));
        //}
        //static int SpaceCounter(string str)
        //{
        //    int space = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            space++;
        //        }
        //    }
        //    return space;
        //}
        #endregion
    }
}
