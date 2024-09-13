using System;

namespace Addition_Of_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[4] { 1, 2, 3, 5 };

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];

            }
            Console.WriteLine("Sum of element in an array: " + sum);
            int arraylength = num.Length + 1;
            int array_Sum = arraylength * (arraylength + 1) / 2;
            Console.WriteLine("Total Sum: " + array_Sum);

            int missingNum = array_Sum - sum;
            Console.WriteLine("Missing number: " + missingNum);
        }
    }
}
