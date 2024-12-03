using System;

namespace Assignment5._1._2
{
    internal class Program
    {
        //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }

            int result = SumOfDigits(Math.Abs(number));
            Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
