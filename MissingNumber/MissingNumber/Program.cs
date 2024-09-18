using System;
using System.Linq;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //MissingNumber();

            TargetNumber();
        }

       /* private static void MissingNumber()
        {
            int[] numbers = new int[6] { 1, 2, 3, 5, 6, 7 };
            int lengthOfArray = numbers.Length + 1;
            int sum = lengthOfArray * (lengthOfArray + 1) / 2;
            int sumOfArray = numbers.Sum();

            int missingNum = sum - sumOfArray;
            Console.WriteLine("Missing Number is: " + missingNum);
        }*/

        public static void TargetNumber()
        {

            int[] numbers = new int[6] { 1, 5, 4, 2, 3, 3 };

            int target = 6;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i]+numbers[j] == target)
                    {
                        Console.WriteLine(numbers[i] + " + " + numbers[j] + "=" + target);
                    }
                }
            }
        }
    }
}
