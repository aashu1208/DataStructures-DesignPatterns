using System;
using System.Linq;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MissingNumber();

        }

        private static void MissingNumber()
        {
            int[] numbers = new int[6] { 1, 2, 3, 5, 6, 7 };
            int lengthOfArray = numbers.Length + 1;
            int sum = lengthOfArray * (lengthOfArray + 1) / 2;
            int sumOfArray = numbers.Sum();

            int missingNum = sum - sumOfArray;
            Console.WriteLine("Missing Number is: " + missingNum);
        }
    }
}
