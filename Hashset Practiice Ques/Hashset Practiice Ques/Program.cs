using System;
using System.Collections.Generic;

namespace Hashset_Practiice_Ques
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> seen = new HashSet<int> { 1, 2, 2, 3, 3, 4 };
            //SeenNumbers(seen);

            int[] numbers = new int[] { 1, 2, 2, 3, 3, 4 };
            FindFrequency(numbers);
            
        }

        

        public static void SeenNumbers(HashSet<int> seen)
        {
            Console.WriteLine("Seen numbers: " + string.Join(",",seen));

        }

        public static void FindFrequency(int[] numbers)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }

                else
                {
                    frequency[num] = 1;
                }
            }

            Console.WriteLine("frequency of numbers are: ");

            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");

            }


        }
    }
}
