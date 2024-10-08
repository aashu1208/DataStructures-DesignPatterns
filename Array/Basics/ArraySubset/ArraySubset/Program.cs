﻿using System;
using System.Collections.Generic;
namespace ArraySubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6 };
            int[] a2 = { 1, 2, 3, 4 };
            int m = a2.Length;
            int n = a1.Length;
            Console.WriteLine (isSubset(a1, a2, m,n));
        }

        public static string isSubset(int[] a1, int[] a2, int m, int n)
        {
            HashSet<int> set1 = new HashSet<int>(a1);
            for (int i = 0; i < m; i++)
            {
                if(!set1.Contains(a2[i]))
                {
                    return "No";
                }
            }
            return "Yes";
        }
    }
}
