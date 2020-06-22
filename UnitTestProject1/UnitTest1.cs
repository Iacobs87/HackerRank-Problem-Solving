using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank_Problem_Solving;
using System.Collections.Generic;
using System.IO.Compression;

namespace UnitTestProject1
{
    [TestClass]
    public class HackerRankUnitTests
    {
        [TestMethod]
        [TestProperty("FizzBuzz", "https://www.hackerrank.com/challenges/fizzbuzz/problem")]
        public void FizzBuzz()
        {
            //arrange
            var test = new Result();
            var n = 15;
            var actual = new List<string>();
            var expected = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8",
                                                "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};

            //act
            actual = test.FizzBuzz(n);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        [TestProperty("PlusMinus", "https://www.hackerrank.com/challenges/plus-minus/problem")]
        public void PlusMinus()
        {
            //arrange
            var arr = new int[6] { -4, 3, -9, 0, 4, 1 };
            var test = new Result();
            var answeer = new List<float>();
            var expected = new List<float> { 0.5f, 0.333333343f, 0.166666672f };

            //act
            answeer = test.PlusMinus(arr);

            //assert
            CollectionAssert.AreEquivalent(expected, answeer);
        }

        [TestMethod]
        [TestProperty("Staircase", "https://www.hackerrank.com/challenges/staircase/problem")]
        public void Staicase()
        {
            //arrange
            var test = new Result();
            //will need to figure out how to unit test this
        }

        [TestMethod]
        [TestProperty("MiniMaxSum", "https://www.hackerrank.com/challenges/mini-max-sum/problem")]
        public void MiniMaxSum()
        {
            //arrange
            var test = new Result();
            var expected = new long[] { 10, 14 };
            var arr = new int[] { 1, 2, 3, 4, 5, };

            //act 
            var actual = Result.MiniMaxSum(arr);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        [TestProperty("BirthDayCandles", "https://www.hackerrank.com/challenges/birthday-cake-candles/problem")]
        public void BirthdayCandles()
        {
            //arrange
            var test = new Result();
            var expected = 2;
            var arr = new int[] { 3, 2, 1, 3 };

            //act
            var actual = test.BirthdayCakeCandles(arr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("MilitaryTime", "https://www.hackerrank.com/challenges/time-conversion/problem")]
        public void TimeConversion()
        {
            //arrange
            var test = new Result();
            var expected = "19:05:45";
            var time = "07:05:45PM";

            //act
            var actual = test.TimeConversion(time);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [TestProperty("GradingStudent", "https://www.hackerrank.com/challenges/grading/problem")]
        public void GradingStudents()
        {
            //arrange
            var test = new Result();
            var expected = new List<int>() { 75, 67, 40, 33 };
            var grades = new List<int> { 73, 67, 38, 33 };

            //act
            var actual = test.GradingStudents(grades);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        [TestProperty("ApplesAndOranges", "https://www.hackerrank.com/challenges/apple-and-orange/problem")]
        public void ApplesAndOranges()
        {
            //arrange
            var test = new Result();
            var expected = new int[] { 1, 2 };
            int s = 7;
            int t = 10;
            int a = 4;
            int b = 12;
            int[] apples = new int[] { 2, 3, -4 };
            int[] oranges = new int[] { 3, -2, -4 };

            //act
            var actual = test.CountApplesAndOranges(s, t, a, b, apples, oranges);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);

        }

        [TestMethod]
        [TestProperty("KangarooProblem", "https://www.hackerrank.com/challenges/kangaroo/problem")]
        public void Kangaroo()
        {
            //arrange
            var test = new Result();
            var x1 = 0;
            var v1 = 3;
            var x2 = 4;
            var v2 = 2;
            var expected = "YES";

            //act
            var actual = test.Kangaroo(x1, v1, x2, v2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("BetweenSets", "https://www.hackerrank.com/challenges/between-two-sets/problem")]
        public void BetweenSeets()
        {
            //arrange
            var test = new Result();
            List<int> a = new List<int> { 2, 4 };
            List<int> b = new List<int> { 16, 32, 96 };
            var expected = 3;
            //act
            var actual = test.BetweenSets(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }




        [TestMethod]
        [TestProperty("Name", "Link")]
        public void s()
        {
            //arrange
            
            //act 

            //assert
        }
    }
}
