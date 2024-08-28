using System;
using System.Collections.Generic;
namespace Data_Structures_List
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int> {1,2,3,4};
            //numbers.AddRange(new List<int> { 4, 5, 6 });
            //numbers.RemoveAt(0);
            //numbers.Insert(0, 7);
            //numbers.ToArray();
            //numbers.Contains(3);
            //int index = numbers.IndexOf(3);
            //int even = numbers.Find(x => x % 2 == 0);
            /*numbers.Sort();
            numbers.Sort((a, b) => b.CompareTo(a));
            numbers.Clear();*/
            //int[] array = numbers.ToArray();
            //int count = numbers.Count;

            //int cap = numbers.Capacity;
            //Console.WriteLine(string.Join(",", cap));

            //Console.WriteLine(cap);

            /*string[] stringNumbers = { "1", "2", "3", "4" };
            Console.WriteLine(string.Join(",", stringNumbers));
            int[] stringToArray = Array.ConvertAll(stringNumbers, int.Parse);
            Console.WriteLine(string.Join(",", stringToArray));
*/
            HashSet<int> num = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> num2 = new HashSet<int> { 5, 6, 7, 8 };

            num.UnionWith(num2);
            //Console.WriteLine(string.Join(",", num));

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("aashu", 1);
            dict.Add("sharma", 2);
            if (dict.TryGetValue("aashu", out int value))
            {
                Console.WriteLine("Value associated with aashu:" + value);
            }

            else
            {
                Console.WriteLine("Value does not exist");
            }

            //Console.WriteLine("{"+string.Join(",", dict)+"}");
            

        }
    }
}
