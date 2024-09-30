using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int n = arr.Length;

            if (n == 0)
            {
                Console.WriteLine("no elements in the array");
            }

            for (int i = 0; i < n; i++)
            {
                if ((i == 0 || arr[i]>=arr[i-1]) && (i == n-1 || arr[i]>= arr[i+1]))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(-1);
        }
    }
}
