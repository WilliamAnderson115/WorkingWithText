using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithText
{
    public static class WorkingWithText
    {
        // 1- Write a method that accepts a string of numbers separated by a hyphen. If the
        // input is incorrect, return false Work out if the numbers are consecutive. For
        // example, if the input is "5-6-7-8-9" or "20-19-18-17-16", return bool True; otherwise,
        // return bool False.
        public static bool IsConsecutive(string hyphenNum)
        {
            var splitInput = hyphenNum.Split("-");

            var parsedInput = new List<int>();

            foreach (var item in splitInput)
            {
                if (int.TryParse(item, out var parsedItem))
                {
                    parsedInput.Add(parsedItem);
                }
                else
                {
                    return false;
                }
            }

            // check for ascending
            var isAscending  = true;
            var isDescending = true;

            for (var i = 0; i < parsedInput.Count - 1; i++)
            {
                if (isAscending && parsedInput[i] + 1 != parsedInput[i + 1])
                {
                    isAscending = false;
                }

                if (isDescending && parsedInput[i] - 1 != parsedInput[i + 1])
                {
                    isDescending = false;
                }

                if (!(isAscending || isDescending))
                {
                    break;
                }
            }

            return isAscending || isDescending;
        }

        // 2- Write a method that accepts a few numbers separated by a hyphen. Check
        // to see if there are duplicates. If so, return bool True; otherwise, return bool False.
        public static bool AreThereDuplicates(string hyphenNum)
        {
            var splitInput = hyphenNum.Split("-");

            var parsedInput = new List<int>();

            var hasDuplicates = false;

            foreach (var item in splitInput)
            {
                if (int.TryParse(item, out var parsedItem))
                {
                    parsedInput.Add(parsedItem);
                }
                else
                {
                    return false;
                }
            }

            parsedInput.Sort();
            for (var j = 0; j < parsedInput.Count - 1; j++)
            {
                if (parsedInput[j] == parsedInput[j + 1])
                {
                    hasDuplicates = true;
                }
            }

            return hasDuplicates;
        }

        // 3- Write a method that accepts a string of a time 24-hour time format
        // (e.g. "09:00"). A valid time should be between 00:00 and 23:59. If the time is valid,
        // return a bool True; otherwise, return a bool False. If the user doesn't provide any values,
        // consider it as False. Make sure that its returns false if any letters are passed.
        public static bool IsValidTime(string hyphenNum)
        {
            if (hyphenNum is null || hyphenNum.Length == 4 || hyphenNum.Any(char.IsLetter))
            {
                return false;
            }

            var splitInput = hyphenNum.Split(":");

            if (splitInput.Length != 2)
            {
                return false;
            }

            if (Convert.ToInt32(splitInput[0]) < 0 || Convert.ToInt32(splitInput[0]) > 23)
            {
                return false;
            }
            if (Convert.ToInt32(splitInput[1]) < 0 || Convert.ToInt32(splitInput[1]) > 60)
            {
                return false;
            }

            return true;
        }

        // 4- Write a method that accepts a string of a few words separated by a space. Use the
        // words to create a variable name with PascalCase. For example, if the user types: "number
        // of students", return "NumberOfStudents". Make sure that the program is not dependent on
        // the input. So, if the user types "NUMBER OF STUDENTS", the program should still return "NumberOfStudents".
        // Trim off unneeded spaces.
        public static string PascalConverter(string aFewWords)
        {
            if (aFewWords is null)
            {
                return null;
            }

            string ModifiedInput = aFewWords.ToLower().Trim(); 
            var splitInput = ModifiedInput.Split(" ");

            string Output = null;
            foreach (var word in splitInput)
            {
                var final = char.ToUpper(word[0]);
                Output += final + word[1..];
            }

            return Output;
        }

        // 5- Write a method that accepts an English word. Count the number of vowels
        // (a, e, i, o, u) in the word. So, if the user enters "inadequate", the program should
        // return 6.
        public static int VowelCounter(string aWord)
        {
            int vowelCount = 0;
            if (string.IsNullOrEmpty(aWord))
            {
                vowelCount = 0;
            }
            else
            {
                aWord = aWord.ToLower();
                for (int i = 0; i < aWord.Length; i++)
                {
                    if (aWord[i] == 'a' || aWord[i] == 'e' || aWord[i] == 'i' || aWord[i] == 'o' || aWord[i] == 'u')
                    {
                        vowelCount++;  
                    }
                }
            }


            return vowelCount;
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