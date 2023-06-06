using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9Part2
{
    public static class task3
    {
        public static void task3Func(string[] args)
        {
            {
                int[] numbers = new int[] { 7, 14, 21, 25, 33, 42, 50, 57, 63, 70, 77, 85, 90, 100 };

                Func<int[], int> countMultiplesOfSeven = (nums) => nums.Count(n => n % 7 == 0);

                int count = countMultiplesOfSeven(numbers);

                Console.WriteLine($"The number of multiples of 7 in the array is: {count}");
            }
        }
    }
}
