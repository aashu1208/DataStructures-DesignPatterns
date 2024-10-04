using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] num = { 1, 3, 5, 4, 6 };
            int target = 9;

            Console.WriteLine(TwoSum(num, target));

        }


        public static int[] TwoSum(int[] num, int target)
        {

            
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i]+num[j] == target)
                    {
                        return new int[] {i,j };
                    }
                }
            }
            return null;
        }
    }
}
