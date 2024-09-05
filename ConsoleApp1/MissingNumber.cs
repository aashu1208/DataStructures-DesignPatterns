using System;
using System.Linq;
public class MissingNumber
{
	public static void Main(string[] args)
    {
        MissingNumber();
        
    }


    public static void MissingNumber()
    {
        int[] num = { 3, 7, 1, 2, 8, 4, 5 };
        int totalLength = num.Length + 1;

        int arraySum = num.Sum();

        int totalSum = (totalLength * (totalLength + 1)) / 2;

        int missingNumber = totalSum - arraySum;
        Console.WriteLine("Total Length: " + totalLength);
        Console.WriteLine("Array Sum: " + arraySum);
        Console.WriteLine("Total Sum: " + totalSum);
        Console.WriteLine("Missing Number is: " + missingNumber);

    }
}
