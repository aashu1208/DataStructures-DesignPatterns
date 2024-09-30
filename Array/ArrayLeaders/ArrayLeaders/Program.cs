using System;
using System.Collections.Generic;

namespace ArrayLeaders
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 2, 4, 1 };
            int n = arr.Length;
            int maxfromRight = arr[n - 1];
            List<int> result = new List<int>();


            result.Add(maxfromRight);
            for (int i = n-2; i >= 0; i--)
            {
                if (arr[i]>=maxfromRight)
                {
                    maxfromRight = arr[i];
                    result.Add(arr[i]);
                }
            }


            result.Reverse();
            foreach (int leaders in result)
            {
                Console.WriteLine(string.Join(",", leaders));
            }
        }
    }

}
