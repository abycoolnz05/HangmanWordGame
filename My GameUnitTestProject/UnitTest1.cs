using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanWordGame;
using Android.Widget;
using System.IO;
using HangmanWordGame.Resources;

namespace My_GameUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public static int score;
        public string letter;
         
        [TestMethod ]
        public void TestMethod1()
        {
            switch (letter)
            {
                case "B":
                case "C":
                case "D":
                case "F":
                case "G":
                case "H":
                case "J":
                case "K":
                case "L":
                case "M":   // All letters 1 pt 
                case "N":
                case "P":
                case "Q":
                case "R":
                case "S":
                case "T":
                case "V":
                case "W":
                case "X":
                case "Y":
                case "Z":
                    score = score + 1;
                    break;
            }
            Assert.IsFalse(score == score + 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            switch (letter)
            {
                case "A":
                case "E":  //All Wovels get 2 pts
                case "I":
                case "0":
                    score = score + 2;
                    break;
            }
            Assert.IsFalse(score == score + 2);
        }
    }
}
