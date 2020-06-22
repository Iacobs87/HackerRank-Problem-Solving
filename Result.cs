using System.Linq;
using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;

namespace HackerRank_Problem_Solving
{

    public class Result
    {

        public List<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    result.Add("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    result.Add("Fizz");
                }

                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    result.Add("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                    result.Add(i.ToString());
                }
            }
            return result;
        }

        public static long[] MiniMaxSum(int[] arr)
        {

            long maxValue = arr.Max();
            long minValue = arr.Min();
            var result = new long[2];

            var sumMin = arr.Sum(v => (long)v) - maxValue;
            var sumMax = arr.Sum(v => (long)v) - minValue;
            Console.WriteLine($"{sumMin} {sumMax}");
            result[0] = sumMin;
            result[1] = sumMax;

            return result;

        }

        public string TimeConversion(string time)
        {
            DateTime dateTime = Convert.ToDateTime(time);
            string militaryDate = dateTime.ToString("HH:mm:ss");
            Console.WriteLine(militaryDate);
            return militaryDate;
        }

        public int[] CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int ax = apples.Where(x => s <= (a + x) && (x + a) <= t).Count();
            int ox = oranges.Where(x => s <= (b + x) && (x + b) <= t).Count();
            Console.WriteLine(ax);
            Console.WriteLine(ox);
            
            var result = new int[2];
            result[0] = ax;
            result[1] = ox;
            return result;
        }

        public List<int> GradingStudents(List<int> grades)
        {
            var response = new List<int>();
            foreach (var grade in grades)
            {               
                {
                    if (grade % 5 < 3 || grade < 38)
                    {
                        response.Add(grade);
                    }

                    else
                    {
                        response.Add(grade + (5 - grade % 5));

                    }

                }
            }

            return response;
        }

        public int BetweenSets(List<int> a, List<int> b)
        {
            var result = 0;
            var start = 0;

            if (a[a.Count - 1] > b[b.Count - 1])
            {
                return result;
            }

            start = a[a.Count - 1] ;
            var diff = b[0] - a[a.Count - 1];
            
            for (int i = 0; i < diff+1; i++)
            {
                
                var isok = true;

                foreach (var number in a)
                {
                    if (start % number != 0)
                    {
                        isok = false;
                    }
                }

                if (isok)
                {
                    foreach (var number in b)
                    {
                        if (number % start != 0)
                        {
                            isok = false;
                        }
                    }
                }
                

                if (isok)
                {
                    result += 1;
                }
                start += 1;
            }

            
            Console.WriteLine(result);
            return result;
            
        }

        public string Kangaroo(int x1, int v1, int x2, int v2)
        {
         string result = "";

            while (x1 < x2)
            {
                x1 += v1;
                x2 += v2;

                if (x1 == x2)
                {
                    result = "YES";
                    break;
                }
                else if (x1 > x2)
                {
                    result = "NO";
                    break;
                }

            }
            return result;
        }

        public int BirthdayCakeCandles(int[] arr)
        {
            var max = arr.Max();

            var count = 0;

            foreach (var item in arr)
            {
                if (item == max)
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
            return count;
        }

        public List<float> PlusMinus(int[] arr)
        {
            int n = arr.Length;
            float resultPositives;
            float resultNegatives;
            float resultZeros;

            var result = new List<float>();

            var a = arr.Count(val => val > 0);
            resultPositives = (float)a / n;
            Console.WriteLine(resultPositives);
            result.Add(resultPositives);

            var b = arr.Count(val => val < 0);
            resultNegatives = (float)b / n;
            Console.WriteLine(resultNegatives);
            result.Add(resultNegatives);

            var c = arr.Count(val => val == 0);
            resultZeros = (float)c / n;
            Console.WriteLine(resultZeros);
            result.Add(resultZeros);

            return result;

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
