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

            start = a[a.Count - 1];
            var diff = b[0] - a[a.Count - 1];

            for (int i = 0; i < diff + 1; i++)
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

        public int[] BreakingTheRecord(int[] scores)
        {
            var low = scores[0];
            var high = scores[0];
            var nLow = 0;
            var nHigh = 0;
            var result = new int[2];

            foreach (var score in scores)
            {
                if (low > score)
                {
                    low = score;
                    nLow += 1;
                }

                if (high < score)
                {
                    high = score;
                    nHigh += 1;
                }
            }

            result[0] = nHigh;
            result[1] = nLow;

            return result;


        }

        public int Birthday(List<int> s, int d, int m)
        {
            var count = 0;
            int l = s.Count;

            for (int i = 0; i < l; i++)
            {
                if (s.Skip(i).Take(m).Sum() == d)
                {
                    count++;
                }
            }

            return count;
        }

        public int DivisibleSumPair(int n, int k, int[] ar)
        {
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        result += 1;
                    }
                }

            }

            return result;
        }

        public int MigratoryBirds(List<int> arr)
        {
            var result = 0;
            var lenght = arr.Count;
            var dic = new Dictionary<int, int>();
            dic.Add(1, 0);
            dic.Add(2, 0);
            dic.Add(3, 0);
            dic.Add(4, 0);
            dic.Add(5, 0);

            for (int i = 0; i < lenght; i++)
            {
                dic[arr[i]]++;
            }

            result = dic.FirstOrDefault(Q => Q.Value == dic.Values.Max()).Key;

            return result;

        }

        public string DayOfTheProgrammer(int year)
        {
            string day = ".09." + year.ToString();
            if (year == 1918)
            {
                day = "26" + day;
            }
            else if (((year < 1918) && (year % 4 == 0)) ||
                    ((year > 1918) && ((year % 400 == 0) ||
                     (year % 4 == 0 && year % 100 != 0))))
                day = "12" + day;
            else
                day = "13" + day;

            return day;

        }

        public string BonAppetit(List<int> bill, int k, int b)
        {
            var result = "";
            var iDontEat = bill.ElementAt(k);
            var totalBill = bill.Sum();
            var correctSplit = (totalBill - iDontEat) / 2;

            if (b == correctSplit)
            {
                Console.WriteLine("Bon Appetit");
                result = "Bon Appetit";
                return result;
            }
            else
            {
                Console.WriteLine(b - correctSplit);
                result = (b - correctSplit).ToString();

                return result;
            }
        }

        public int SockMerchant(int n, int[] ar)
        {
            var result = 0;

            result = ar.GroupBy(a => a).Sum(a => a.Count() / 2);

            return result;
        }

        public int PageCount(int n, int p)
        {
            var result = 0;

            result = Math.Min(p / 2, n / 2 - p / 2);

            return result;
        }

        public int CountingValleys(int n, string s)
        {
            var count = 0;
            char[] arr = s.ToCharArray();
            var level = 0;
       
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 'U')
                {
                    if (++level == 0)
                    {
                        count++;
                    }
                }
                else
                    level--;

            }
            return count;
        }

        public int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxSum = -1;            
            Array.Sort(keyboards);
            Array.Sort(drives);
            Array.Reverse(drives);

            List<int> keyboardsList = keyboards.OfType<int>().ToList();
            List<int> drivesList = drives.OfType<int>().ToList();

            


            if (keyboards.Min() + drives.Min() > b)
                return -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] > b)
                        break;
                    if ((int)(keyboards[i] + drives[j]) > maxSum)
                    {
                        maxSum = (int)(keyboards[i] + drives[j]);
                    }

                }
            }

            return maxSum;
        }

        public string CatandMouse(int x, int y, int z)
        {
            string result = "";
            var d1 = 0;
            var d2 = 0;

            d1 = Math.Abs(z - x);
            d2 = Math.Abs(z - y);

            if (d1 > d2)
            {
                result = "Cat B";
            }
            else if (d1 < d2)
            {
                result = "Cat A";
            }
            else
            {
                result = "Mouse C";
            }
            return result;
        }

        public int PickingNumbers(List<int> a)
        {
            //var maxCount = 0;
            //var currCount = 0;
            //var fi = 0;

            //a.Sort();

            //if (a.Count == 0)
            //{
            //    return 0;
            //}

            //for (int i = 0; i < a.Count; i++)
            //{
            //    if (Math.Abs(a[fi] -a[i]) == 0)
            //    {
            //        if (currCount == 0)
            //        {
            //            currCount = 2;
            //        }
            //        else
            //            currCount++;

            //        if (currCount > maxCount)
            //        {
            //            maxCount = currCount;
            //        }
            //    }
            //    else
            //    {
            //        currCount = 0;
            //        fi = i;
            //    }
            //}

            //return maxCount;

            int max = 0;
            int[] values = new int[102];
            for (int i = 0; i < a.Count; i++)
            {
                values[a[i]]++;
                if (max < values[a[i] - 1] + values[a[i]])
                {
                    max = values[a[i] - 1] + values[a[i]];
                }
                if (max < values[a[i]] + values[a[i] + 1])
                {
                    max = values[a[i]] + values[a[i] + 1];
                }
            }
            return max;
        }

        public int HurdleRace(int k, int[] height)
        {
            var noPotions = 0;

            var maxheigth = height.Max();

            noPotions = maxheigth - k;

            if (noPotions > 0)
            {
                return noPotions;
            }
            else
                return 0;

        }

        public int DesignerPdfViewer(int[]h, string word)
        {
            int tallestLetter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine((int)word[i]);
                if (h[(int)word[i] -97] > tallestLetter)
                {
                    tallestLetter = h[(int)word[i] - 97];
                }
            }

            return tallestLetter * word.Length;
        }

        public int UtopianTree(int n)
        {
            var result = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    result *= 2;
                }
                else
                {
                    result += 1;
                }
            }

            return result;

        }

        public string AngryProfessor(int k, int[] a)
        {
            var studentCount = a.Where(i => i <= 0).Count();

            if (studentCount >= k)
            {
                return "NO";
            }
            else
                return "YES";

        }


    }   
}
