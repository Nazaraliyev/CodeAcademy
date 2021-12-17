using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CA_Task_11
{
    class Program
    {
        #region Task 1
        // Modified
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5, 5, 7 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(DublicateNumber(arr));

        }

        static int DublicateNumber(int[] array)
        {
            int[] dubl = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j] && Array.TrueForAll(dubl, elem => elem != array[i]))
                    {
                        Array.Resize(ref dubl, dubl.Length + 1);
                        dubl[dubl.Length - 1] = array[i];
                    }
                }
            }

            int[] dublcount = new int[0] { };
            foreach (var item in dubl)
            {
                Console.Write(item + " ");
                int[] arrayFind = Array.FindAll(array, elem => elem == item);
                int count = dublcount.Length + arrayFind.Length;
                Array.Resize(ref dublcount, count);
                arrayFind.CopyTo(dublcount, count - arrayFind.Length);
            }
            Console.WriteLine();
            return dublcount.Length;

        }
        #endregion

        #region Task 2
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5 };
        //    Console.WriteLine(Exists(arr, 8));
        //    // Console.WriteLine(Array.Exists(arr, elem => elem == 8));
        //}
        //static bool Exists(int[] array, int num)
        //{
        //    bool boolValue;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        #endregion

        #region Task 3
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5 };
        //    Array.Reverse(arr);
        //    //for (int i = 0; i < arr.Length; i++)
        //    //{
        //    //    Console.Write(arr[i]);
        //    //}
        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}
        #endregion

        #region Task 4
        //static void Main(string[] args)
        //{
        //    int[] arr0 = new int[4] { 2, 3, 5, 1 };
        //    int[] arr1 = new int[4] { 6, 9, 6, 4 };
        //    int[] MergeArr = new int[arr0.Length + arr1.Length];
        //    arr0.CopyTo(MergeArr, 0);
        //    arr1.CopyTo(MergeArr, arr0.Length);
        //    Array.Sort(MergeArr);
        //    for (int i = MergeArr.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(MergeArr[i] + " ");
        //    }
        //}
        #endregion

        #region Task 5
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5 };
        //    int maks = arr[0];
        //    int min = arr[0];

        //    //Console.WriteLine("Max : " + arr.Max());
        //    //Console.WriteLine("Min : " + arr.Min());
        //    //Console.WriteLine("Sum : " + arr.Sum());
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > maks) maks = arr[i];
        //        else if (min > arr[i]) min = arr[i];
        //    }

        //    Console.WriteLine(min + " " + maks);
        //}

        #endregion

        #region Task 6
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5 };
        //    int[] sing = new int[0];
        //    int[] pair = new int[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if(arr[i]%2 == 1)
        //        {
        //            Array.Resize(ref sing, sing.Length + 1);
        //            sing[sing.Length - 1] = arr[i];
        //        }
        //        else
        //        {
        //            Array.Resize(ref pair, pair.Length + 1);
        //            pair[pair.Length - 1] = arr[i];
        //        }
        //    }

        //    foreach (var elem in sing)
        //    {
        //        Console.Write(elem + " ");
        //    }
        //    Console.WriteLine();
        //    foreach (var elem in pair)
        //    {
        //        Console.Write(elem + " ");
        //    }
        //}

        #endregion

        #region Task 7
        //static void Main(string[] args)
        //{
        //    string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
        //    Console.WriteLine(str.Substring(0, 50));
        //}
        #endregion

        #region Task 8
        //static void Main(string[] args)
        //{
        //    string str = "   Hello p121   ";
        //    str = str.Trim();
        //    Console.WriteLine(str);
        //}
        #endregion

        #region Task 9
        //static void Main(string[] args)
        //{
        //    string str = "Hello p121";
        //    Console.WriteLine(str.Length);
        //}
        #endregion

        #region Task 10
        //static void Main(string[] args)
        //{
        //    string str = "Welcome, ca!";
        //    for (int i = str.Length-1; i >= 0; i--)
        //    {
        //        Console.Write(str[i] + " ");
        //    }
        //}
        #endregion

        #region Task 11
        //static void Main(string[] args)
        //{
        //    string str = "    Lorem    Ipsum dolar halah     ";
        //    str = str.Trim();
        //    Regex rgx = new Regex(@"\s+");
        //    int count = 0;
        //    while(Regex.IsMatch(str, @"\s+"))
        //    {
        //        count++;
        //        str = rgx.Replace(str, "", 1);
        //    }
        //    count++;
        //    Console.WriteLine(count);
        //}
        #endregion

        #region Task 12
        //static void Main(string[] args)
        //{
        //    string str = "the string where the word the present more that once";
        //    string[] strArray = Regex.Split(str, @"\s+");
        //    int count = 0;
        //    foreach (var item in strArray)
        //    {
        //        if(item == "the")
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        // }
        #endregion
    }
}
