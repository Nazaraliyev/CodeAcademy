using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil edin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Operation(a,b));
            Console.WriteLine(SumOfNumber(a,b));


            // Task 1
            // Ededlerin Hasili ve Cemi
            static string Operation(int a, int b)
            {
                int sum = a + b;
                int mlt = a * b;
                return $"Toplam : {sum},\nHasil : {mlt}";
            }


            // Task 2
            // a ve b ededleri arasinda ededlerin cemi
            // Biraz modifikasiya etdim, 1-ci ededin kicik olmasina ehtiyac yoxdur,
            // Amma olsaydi)) While loop-u istifade ederdim, duzgun daxil edene kimi while break olmazdi...
            static int SumOfNumber(int a, int b)
            {
                int result;
                if (b > a)
                {
                    result = opr(a, b);
                }
                else
                {
                    result = opr(b, a);
                }
                static int opr(int first, int last)
                {
                    int sum = 0;
                    for (int i = first; i <= last; i++)
                    {
                        sum = sum + i;
                    }
                    return sum;
                }
                return result;
            }
        }
    }
}
