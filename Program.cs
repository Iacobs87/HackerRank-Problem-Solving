using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Solving
{
    public class Program
    {
        static void Main(string[] args)
        {

            //fizz buz

            // Result.fizzBuzz(15);

            // Plus Minus problem

            //Console.WriteLine("Give me the array separated by spaces \" \" ");

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            //Result.PlusMinus(arr);

            //stair cases problem

            //Result.StairCase(10);

            //Mini-Max Sum

            //int[] arr = new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //Result.MiniMaxSum(arr);

            //Birthday Cake Candles

            //int[] arr = new int[] { 3, 2, 1, 3 };

            // Result.BirthdayCakeCandles(arr);

            //Time conversion

            //string time = "12:40:22AM";
            //Result.TimeConversion(time);

            //Grading students

            var grades = new List<int> { 24, 33, 54, 62, 88 };

            Result.GradingStuden(grades);

        }
    }
}
