using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Days_of_Code
{
    class Day20Sorting
    {
        static public int[] bubbleSort(int[] tab)
        {
            int swap=1;
            int allSwap = 0;
            while (swap > 0)
            {
                swap = 0;
                for (int i = 0; i < tab.Count()-1; i++)
                {

                    if (tab[i] > tab[i + 1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        swap++;
                    }
                }
                allSwap+= swap;

            }

            Console.WriteLine("Array is sorted in {0:} swaps.\nFirst Element: {1:}\nLast Element: {2:}"
                , allSwap, tab.First(), tab.Last());

            return tab;
        }
        static void Main(String[] args)
        {
            //int[] t = { 4, 3, 8, 1, 5 };
            //int[] t2 = bubbleSort(t);
            //t2.ToList().ForEach(Console.WriteLine);


            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            bubbleSort(a).ToList().ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }
}
