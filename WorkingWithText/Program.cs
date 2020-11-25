using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithText
{
    public static class WorkingWithText
    {
        // 1- Write a method that accepts a string of numbers separated by a hyphen. If the
        // input is incorrect, return false. Work out if the numbers are consecutive. For
        // example, if the input is "5-6-7-8-9" or "20-19-18-17-16", return bool True; otherwise,
        // return bool False.
        public static bool IsConsecutive(string hyphenNum)
        {
            return default;
        }

        // 2- Write a method that accepts a few numbers separated by a hyphen. Check
        // to see if there are duplicates. If so, return bool True; otherwise, return bool False.
        public static bool AreThereDuplicates(string hyphenNum)
        {
            return default;
        }

        // 3- Write a method that accepts a string of a time 24-hour time format
        // (e.g. "09:00"). A valid time should be between 00:00 and 23:59. If the time is valid,
        // return a bool True; otherwise, return a bool False. If the user doesn't provide any values,
        // consider it as False. Make sure that its returns false if any letters are passed.
        public static bool IsValidTime(string hyphenNum)
        {
 			return default;
        }

        // 4- Write a method that accepts a string of a few words separated by a space. Use the
        // words to create a variable name with PascalCase. For example, if the user types: "number
        // of students", return "NumberOfStudents". Make sure that the program is not dependent on
        // the input. So, if the user types "NUMBER OF STUDENTS", the program should still return "NumberOfStudents".
        // Trim off unneeded spaces.
        public static string PascalConverter(string aFewWords)
        {
        	return default;
        }

        // 5- Write a method that accepts an English word. Count the number of vowels
        // (a, e, i, o, u) in the word. So, if the user enters "inadequate", the program should
        // return 6.
        public static int VowelCounter(string aWord)
        {
            return default;
        }
    }


    internal static class Program
    {
        private static void Main()
        {
            // Method intentionally left empty.
        }
    }
}
