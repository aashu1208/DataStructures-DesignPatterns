using System;
using System.Collections.Generic;
namespace First_Non_Repeating_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "swiss";
            int frequency_Of_Character;

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char currentChar in inputString)
            {
                if (freq.ContainsKey(currentChar))
                {
                    frequency_Of_Character = freq[currentChar]++;
                    //Console.WriteLine(frequency_Of_Character);
                }

                else
                {
                    frequency_Of_Character = freq[currentChar] = 1;
                    //Console.WriteLine(frequency_Of_Character);
                }
            }

            foreach (KeyValuePair<char, int> kvp in freq)
            {
                Console.WriteLine("Character: " + kvp.Key + " Count:" + kvp.Value);
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
