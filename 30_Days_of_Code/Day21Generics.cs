using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Days_of_Code
{
    class Day21Generics
    {
        public static void PrintArray<T>(T[] arr)
        {
            foreach (T t in arr)
                Console.WriteLine(t);
        }

        public static void PrintArray2<T>(IList<T> list)
        {
            foreach (T t in list)
                Console.WriteLine(t);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //n = Convert.ToInt32(Console.ReadLine());
            //string[] stringArray = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    stringArray[i] = Console.ReadLine();
            //}
            //PrintArray<String>(stringArray);

            PrintArray2<Int32>(intArray);

            Console.ReadLine();

        }
    }
}
