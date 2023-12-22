using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 9 };

        var duplicates = numbers
            .GroupBy(x => x)
            .Where(group => group.Count() > 1)
            .Select(group => group.Key);

        Console.WriteLine("Duplicate elements: " + string.Join(", ", duplicates));
    }
}
