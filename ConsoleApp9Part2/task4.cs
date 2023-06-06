using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9Part2
{
    public static class task4
    {
        public static void task4Func(string[] args)
        {
            int[] numbers = new int[] { -10, 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

            Func<int[], int> countPositiveNumbers = (nums) => nums.Count(n => n > 0);

            int count = countPositiveNumbers(numbers);

            Console.WriteLine($"The number of positive numbers in the array is: {count}");
        }
    }
}
