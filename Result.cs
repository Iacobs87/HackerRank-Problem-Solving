using System.Linq;
using System;

namespace HackerRank_Problem_Solving
{

    public class Result
    {

        public static void fizzBuzz(int n)
        {


            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }

        }

        public static void MiniMaxSum(int[] arr)
        {

            long maxValue = arr.Max();
            long minValue = arr.Min();

            var sumMin = arr.Sum(v => (long)v) - maxValue;
            var sumMax = arr.Sum(v => (long)v) - minValue;
            Console.WriteLine($"{sumMin} {sumMax}");

        }

        public static void PlusMinus(int[] arr)
        {
            int n = arr.Length;
            float result;

            var a = arr.Count(val => val > 0);
            result = (float)a / n;
            Console.WriteLine(result);

            var b = arr.Count(val => val < 0);
            result = (float)b / n;
            Console.WriteLine(result);

            var c = arr.Count(val => val == 0);
            result = (float)c / n;
            Console.WriteLine(result);

        }

        public static void StairCase(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine(new string('#', i + 1).PadLeft(v, ' '));
            }

        }

    }

}
