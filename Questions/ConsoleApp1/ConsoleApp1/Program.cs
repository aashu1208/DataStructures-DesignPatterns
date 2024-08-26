using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listWithDuplicates = new List<int> { 1, 2, 2, 4, 5 };
            HashSet<int> converting = new HashSet<int>(listWithDuplicates);
            List<int> listWithoutDuplicates = new List<int>(converting);

            foreach (int lists in listWithoutDuplicates)
            {
                Console.WriteLine(lists);
            }*/


            List<int> numbers = new List<int> { 4, 7, 3, 8, 5, 6 };
            /*numbers.Reverse();
            Console.WriteLine(string.Join(",", numbers));*/

            /*int left = 0;
            int right = numbers.Count - 1;

            while (left<right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine("Reversed numbers: " + string.Join(",", numbers));
*/
            //int target = 3;
            /*bool found = numbers.Contains(target);

            Console.WriteLine(found ? "item found" : "Not found");*/
            /*
                        int index = numbers.BinarySearch(target);
                        Console.WriteLine(index >= 0 ? $"items found at index: {index}" : "Not found");*/

            numbers.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(",", numbers));
         }
    }
}
