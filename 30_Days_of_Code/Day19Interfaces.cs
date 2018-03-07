using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Days_of_Code
{
    
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    //Write your code here
    class Calculator : AdvancedArithmetic
    {
        public Calculator() { }
        public int divisorSum(int n)
        {
            if (n == 1) return 1;
            return Enumerable.Range(1, n/2).Select(i => n % i == 0 
                        ? n % (n + 1 - i) == 0 ? n + 1 - i + i: i : 0).Sum();

            //if (n == 1) return 1;

            //int sum = 0;
            //for(int i = 1; i <= (n / 2); i++)
            //{
            //    if (n % i == 0)
            //        sum += i;

            //    if (n % (n + 1 - i) == 0)
            //        sum += n + 1 - i;
            //}

            //return sum;
        }
    }
    class Day19Interfaces
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);

            Console.ReadLine();
        }
    }
}
