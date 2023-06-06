using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9Part2
{
    public static class task5
    {
        public static void task5Func(string[] args)
        {
            int[] numbers = new int[] { -1, 1, -2, 3, -4, -4, -2, 5, -6, -6, 7, -8, -8, 9, -10, -10 };

            Func<int[], IEnumerable<int>> getUniqueNegativeNumbers = (nums) => nums.Where(n => n < 0).Distinct();

            var uniqueNegativeNumbers = getUniqueNegativeNumbers(numbers);

            Console.WriteLine("Unique negative numbers in the array are:");
            foreach (var number in uniqueNegativeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
