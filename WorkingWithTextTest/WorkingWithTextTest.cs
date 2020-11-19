using WorkingWithText;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithTextTest
{
    
    // 1- Write a method that accepts a string of positive integers separated by hyphens, if the input is incorrect, return false.
    // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or
    // "20-19-18-17-16", return bool True; otherwise, return bool False. If the string
    // is badly formatted, also return false.
    [TestClass]
    public class IsConsecutiveTest
    {
        //Random randomNum = new Random();


        [TestMethod]
        public void IsInputHyphenated()
        {
            //var rambo = randomNum.Next(0, 51);

            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6-4 2,9");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsInputMultiHyphenated()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6--4-2---9");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsInputConsecutiveAscending()
        {     
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("0-1-2-3-4");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsInputConsecutiveDescending()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("9-8-7-6");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsInputNotConsecutive()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("2-2-2-2");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsEveryOtherInputNotConsecutive()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("14-16-18-20");

            Assert.IsFalse(actual);
        }       
    }




    // 2- Write a method that accepts a few integers separated by a hyphen. If the input is incorrect, return false. Check
    // to see if there are duplicates. If so, return bool True; otherwise, return bool False.
    [TestClass]
    public class AreThereDuplicatesTest
    {

        [TestMethod]
        public void IsInputHyphenated()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6-4 2,9");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsInputMultiHyphenated()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6--4-2---9");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void DoesInputHaveDuplicates()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6-4-6-1");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsInputOnlyDuplicates()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("7-7-7-7");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DoesInputHaveMultipleDuplicates()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("6-7-6-7-6-7");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DoesInputHaveNoDuplicates()
        {
            var actual = WorkingWithText.WorkingWithText.IsConsecutive("1-24-6-48");

            Assert.IsFalse(actual);
        }
    }

    // 3- Write a method that accepts a string of a time in 24-hour time format
    // (e.g. "09:00"). A valid time should be between 00:00 and 23:59. If the time is valid,
    // return a bool True; otherwise, return a bool False. If the user doesn't provide any values,
    // consider it as False.
    [TestClass]
    public class IsValidTimeTest
    {
        [TestMethod]
        public void IsTimeEmpty()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime(null);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void DoesTimeHaveAColon()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("1200");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void DoesTimeHaveNoSpace()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("12 13");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TimeHasCorrectFormat()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("13:45");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsTimeStartOfDay()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("00:00");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsTimeEndOfDay()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("23:59");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void AreMinutesBelow60()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("12:63");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AreHoursBelow24()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("24:05");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void DoesTimeHaveLeading0()
        {
            var actual = WorkingWithText.WorkingWithText.IsValidTime("09:39");

            Assert.IsTrue(actual);
        }
    }

    // 4- Write a method that accepts a string of words separated by spaces with no special characters. Use the
    // words to create a variable name with PascalCase. For example, if the user types: "number
    // of students", return "NumberOfStudents". Make sure that the program is not dependent on
    // the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
    // If string is empty, return the empty string.
    [TestClass]
    public class PascalConverterTest
    {
        [TestMethod]
        public void CorrectlyProcessesEmptyString()
        {           
            var actual = WorkingWithText.WorkingWithText.PascalConverter(null);

            Assert.IsTrue(string.IsNullOrEmpty(actual));
        }

        [TestMethod]
        public void DoesStringChangeToOneWord()
        {
            var expected = "HouseForDogs";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("House For Dogs");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPascalCase()
        {
            var expected = "DoesItRain";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("does it rain");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPascalCaseFromAllCaps()
        {
            var expected = "FunForAll";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("FUN FOR ALL");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPascalCaseFromAlternatingCaps()
        {
            var expected = "WhatIsMyNameJimmyBoi";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("WHAT Is my NaMe JiMmY bOi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPascalCaseFromOneWord()
        {
            var expected = "Funforall";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("FunForAll");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPascalCaseFromLetters()
        {
            var expected = "WHY";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("w h y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesInputTrim()
        {
            var expected = "Yeet";

            var actual = WorkingWithText.WorkingWithText.PascalConverter("yeet ");

            Assert.AreEqual(expected, actual);
        }
    }


    // 5- Write a method that accepts one string with no special characters. Count the number of vowels
    // (a, e, i, o, u) in the word. For this prompt "y" will not classify as a vowel. So, if the user enters "inadequate", the program should
    // return 6. If the user enters "InAdEqUaTe" it should still say 6. If string is empty, return 0.
    [TestClass]
    public class VowelCounterTest
    {
        [TestMethod]
        public void IsStringEmpty()
        {
            var expected = 0;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NoVowelWord()
        {
            var expected = 0;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("why");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OnlyVowelWord()
        {
            var expected = 6;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("Euouae");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectVowelCount()
        {
            var expected = 3;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("Pentagon");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VowelCounterIsNotCaseSensitive()
        {
            var expected = 5;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("AeIoU");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoreThanOneWord()
        {
            var expected = 7;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("the dog ate my homework");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JustOneLetter()
        {
            var expected = 0;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JustOneVowel()
        {
            var expected = 1;

            var actual = WorkingWithText.WorkingWithText.VowelCounter("e");

            Assert.AreEqual(expected, actual);
        }

    }

}
