using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank_Problem_Solving;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

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
        [TestProperty("BreakingTheRecord", "https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem")]
        public void BreakingTheRecord()
        {
            //arrange
            var test = new Result();
            int[] scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            var expected = new int[] { 4, 0 };

            //act
            var actual = test.BreakingTheRecord(scores);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        [TestProperty("Birthday", "https://www.hackerrank.com/challenges/the-birthday-bar/problem")]
        public void Birthday()
        {
            //arrange
            var test = new Result();
            List<int> s = new List<int>() { 1, 2, 1, 3, 2 };
            var d = 3;
            var m = 2;
            var expected = 2;

            //act 
            var actual = test.Birthday(s, d, m);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("DivisibleSum", "https://www.hackerrank.com/challenges/divisible-sum-pairs/problem")]
        public void DivisbleSum()
        {
            //arrange
            var test = new Result();
            var n = 6;
            var k = 3;
            var ar = new int[] { 1, 3, 2, 6, 1, 2 };
            var expected = 5;

            //act 
            var actual = test.DivisibleSumPair(n, k, ar);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("MigratoryBirds", "https://www.hackerrank.com/challenges/migratory-birds/problem")]
        public void MigratoryBirds()
        {
            //arrange
            var test = new Result();
            var arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            var expected = 3;

            //act 
            var actual = test.MigratoryBirds(arr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("DayOfTheProgrammer", "https://www.hackerrank.com/challenges/day-of-the-programmer/problem")]
        public void DayOfTheProgrammer()
        {
            //arrange
            var test = new Result();
            var year1 = 2016;
            var year2 = 2017;
            var year3 = 1918;
            var expected1 = "12.09.2016";
            var expected2 = "13.09.2017";
            var expected3 = "26.09.1918";

            //act 
            var actual1 = test.DayOfTheProgrammer(year1);
            var actual2 = test.DayOfTheProgrammer(year2);
            var actual3 = test.DayOfTheProgrammer(year3);

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        [TestProperty("BonAppetit", "https://www.hackerrank.com/challenges/bon-appetit/problem")]
        public void BonAppetit()
        {
            //arrange
            var test = new Result();
            var bill1 = new List<int>() { 3, 10, 2, 9 };
            var bill2 = new List<int>() { 3, 10, 2, 9 };
            var k1 = 1;
            var k2 = 1;
            var b1 = 12;
            var b2 = 7;
            var expected1 = "5";
            var expected2 = "Bon Appetit";

            //act 
            var actual1 = test.BonAppetit(bill1, k1, b1);
            var actual2 = test.BonAppetit(bill2, k2, b2);

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        [TestProperty("SockMerchant", "https://www.hackerrank.com/challenges/sock-merchant/problem")]
        public void SockMerchant()
        {
            //arrange
            var test = new Result();
            var ar = new int[] { 1, 3, 1, 3, 1, 3, 3, 1, 3, 2 };
            var n = 10;
            var expected = 4;
            
            //act 
            var actual = test.SockMerchant(n, ar);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("DrawingBook", "https://www.hackerrank.com/challenges/drawing-book/problem")]
        public void DrawingBook()
        {
            //arrange
            var test = new Result();
            var p = 2;
            var n = 6;
            var expected = 1;

            //act 
            var actual = test.PageCount(n, p);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("CountingValley", "https://www.hackerrank.com/challenges/counting-valleys/problem")]
        public void CountingValley()
        {
            //arrange
            var test = new Result();
            var n = 8;
            var s = "UDDDUDUU";
            var expected = 1;

            //act 
            var actual = test.CountingValleys(n, s);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("GetMoneySpent", "https://www.hackerrank.com/challenges/electronics-shop/problem?h_r=next-challenge&h_v=zen")]
        public void ElectronicsShop()
        {
            //arrange
            var test = new Result();
            int[] keyboards = new int[] { 3, 1 };
            int[] drives = new int[] { 5, 2, 8 };
            var b = 10;
            var expected = 9;

            //act 
            var actual = test.GetMoneySpent(keyboards, drives, b);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [TestProperty("CatandMouse", "https://www.hackerrank.com/challenges/cats-and-a-mouse/problem")]
        public void CatAndMouse()
        {
            //arrange
            var test = new Result();
            int x = 1;
            int y = 2;
            int z = 3;
            var expected = "Cat B";
            //act 
            var actual = test.CatandMouse(x, y, z);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("PickingNumbers", "https://www.hackerrank.com/challenges/picking-numbers/problem")]
        public void PickingNumbers()
        {
            //arrange
            var test = new Result();
            List<int> a = new List<int>() { 4, 6, 5, 3, 3, 1 };
            var expected = 3;

            //act 
            var actual = test.PickingNumbers(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("HurdleRace", "https://www.hackerrank.com/challenges/the-hurdle-race/problem")]
        public void HurdleRace()
        {
            //arrange
            var test = new Result();
            var k = 4;
            int[] height = { 1, 6, 3, 5, 2 };
            var expected = 2;

            //act
            var actual = test.HurdleRace(k, height);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("DesignerPdfViewer", "https://www.hackerrank.com/challenges/designer-pdf-viewer/problem")]
        public void DesignerPdfViewer()
        {
            //arrange
            var test = new Result();
            int[] h = new int[] {1,3,1,3,1,4,1,3,2,5,5,5,5,5,5 } ;
            string word = "abc";
            var expected = 9;

            //act 
            var actual = test.DesignerPdfViewer(h, word);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("UtopianTree", "https://www.hackerrank.com/challenges/utopian-tree/problem")]
        public void UtopianTree()
        {
            //arrange
            var test = new Result();
            var n = 4;
            var expected = 7;

            //act 
            var actual = test.UtopianTree(n);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestProperty("AngryProfessor", "https://www.hackerrank.com/challenges/angry-professor/problem")]
        public void AngryProfessor()
        {
            //arrange
            var test = new Result();
            int[] a1 = new int[] { 23, -35, -2, 58, -67, -56, -42, -73, -19, 37 };
            int[] a2 = new int[] { 13, 91, 56, -62, 96, -5, -84, -36, -46, -13 };
            int[] a3 = new int[] { 45, 67, 64, -50, -8, 78, 84, -51, 99, 60 };
            int[] a4 = new int[] { 26, 94, -95, 34, 67, -97, 17, 52, 1, 86 };
            int[] a5 = new int[] { 19, 29, -17, -71, -75, -27, -56, -53, 65, 83 };

            var k1 = 10;
            var k2 = 9;
            var k3 = 8;
            var k4 = 7;
            var k5 = 2;

            var expected1 = "YES";
            var expected2 = "NO";

            //act 
            var actual1 = test.AngryProfessor(k1, a1);
            var actual2 = test.AngryProfessor(k2, a2);
            var actual3 = test.AngryProfessor(k3, a3);
            var actual4 = test.AngryProfessor(k4, a4);
            var actual5 = test.AngryProfessor(k5, a5);

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected1, actual2);
            Assert.AreEqual(expected1, actual3);
            Assert.AreEqual(expected1, actual4);
            Assert.AreEqual(expected2, actual5);
            
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
