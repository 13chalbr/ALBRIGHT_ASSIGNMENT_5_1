using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_5_1
{
    internal class Program
    {
        // MSSA CCAD16 - Chris Albright
        // Assignment 5.1
        // 02DEC2024
        static void Main(string[] args)
        {
            // Assignment 5.1.1 ---------------------------------------------------------------------------------------------

            // Given an integer x, return true if x is a palindrome, and false otherwise.
            Console.WriteLine("Assignment 5.1.1 ----------------------------------------------------------------------------");
            Console.WriteLine("Palindromic Check:");
            char hold1 = 'y';
            do
            {
                Console.WriteLine("\nEnter the size of your array:");
                int size = int.Parse(Console.ReadLine());
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Enter the value for element {i + 1}:");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Your array is as follows:");
                Console.Write("[");
                foreach (int i in array)
                {
                    Console.Write(i+" ");
                }
                Console.Write("]");
                Console.WriteLine($"\n\nPalindromic number test result: {PalindromicNumberChecker(array)}");
                Console.WriteLine($"\nWant to go again? type y/n");
                hold1 = Convert.ToChar(Console.ReadLine());
            }
            while (hold1 == 'y');

            // Assignment 5.1.2 ---------------------------------------------------------------------------------------------

            // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Console.WriteLine("\nAssignment 5.1.2 ----------------------------------------------------------------------------");
            Console.WriteLine("\nStringofIntegers Summer:");
            char hold2 = 'y';
            do
            {
                Console.WriteLine("\nEnter your string of numbers below:");
                string inputString = Console.ReadLine();  
                int sum = inputString.Where(char.IsDigit).Select(c => int.Parse(c.ToString())).Sum();
                Console.WriteLine($"\nThe sum of all numbers in {inputString} = {sum}");
                Console.WriteLine($"\nWant to go again? type y/n");
                hold2 = Convert.ToChar(Console.ReadLine());
            }
            while (hold2 == 'y');

            // Assignment 5.1.3 ---------------------------------------------------------------------------------------------

            // Given an integer array nums, return true if any value appears at least twice in the array, and return false if
            // every element is distinct.
            Console.WriteLine("\nAssignment 5.1.3 ----------------------------------------------------------------------------");
            Console.WriteLine("\nArray Duplicate Checker:");
            char hold3 = 'y';
            do
            {
                Console.WriteLine("\nEnter the size of your array:");
                int size = int.Parse(Console.ReadLine());
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Enter the value for element {i + 1}:");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Your array is as follows:");
                Console.Write("[");
                foreach (int i in array)
                {
                    Console.Write(i+"");
                }
                Console.Write("]");
                Console.WriteLine($"\n\nDuplicate in array test result: {ArrayDuplicateChecker(array)}");
                Console.WriteLine($"\nWant to go again? type y/n");
                hold3 = Convert.ToChar(Console.ReadLine());
            }
            while (hold3== 'y');
            Console.WriteLine("\n\nGoodbye!");
        }
        //----------------------------------------------------METHODS--------------------------------------------------------
        //5.1.1 Method
        public static bool PalindromicNumberChecker(int[] array)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        //5.1.3 Method
        public static bool ArrayDuplicateChecker(int[] array)
        {
            Dictionary<int,int> numberCounts = new Dictionary<int,int>();
            foreach(int var in array)
            {
                if (!numberCounts.ContainsKey(var))
                {
                    numberCounts[var] = 1;
                }
                else
                {
                    numberCounts[var]++;
                }
            }
            foreach (var kvp in numberCounts)
            {
                if (kvp.Value > 1)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}

