using System;
using System.Collections.Generic;
namespace Data_Structures_List
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.AddRange(new List<int> { 4, 5, 6 });
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
