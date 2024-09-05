using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        /*// Example array
        int[] num = { 4, -3, 9, -4, -9, 1, 2 };

        // Create a HashSet to store the numbers we've seen
        HashSet<int> seenNumbers = new HashSet<int>();

        // Iterate through each number in the array
        foreach (int current in num)
        {
            // Check if the opposite number exists in the set
            if (seenNumbers.Contains(-current))
            {
                // If the current number is positive, print it
                if (current > 0)
                {
                    Console.WriteLine("Positive number with its negative counterpart: " + current);
                }
                // If the current number is negative, print its positive counterpart
                else
                {
                    Console.WriteLine("Positive number with its negative counterpart: " + -current);
                }
            }

            // Add the current number to the set
            seenNumbers.Add(current);
        }*/
        //Find_Pos_Neg_Counterparts_Num();
        //PairOfNumbers();
        
    }

    /*public static void Find_Pos_Neg_Counterparts_Num()
    {
        int[] num = { 1, 2, 3, 4, 5, 6, -1, -2, -3 };
        HashSet<int> numberSeen = new HashSet<int>();

        foreach (int items in num)
        {
            if (numberSeen.Contains(-items))
            

                if(items >0)
                    Console.WriteLine("positive numbers of negative: "+items);
            

                else
                {
                    Console.WriteLine("Negative number of positive: " + (-items));
                }

            numberSeen.Add(items);
        }

        

    }*/

    public static void PairOfNumbers()
    {

        int[] arr = { 2, 4, 3, 5, 7, 8, 1 };
        for (int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j<arr.Length; j++)
            {
                if(arr[i]+arr[j] == 6)
                Console.WriteLine("target achieved using: " + arr[i] + ":" + arr[j]);
                
            }
        }

    }
}
