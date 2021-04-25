using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int sum = RecursiveSum(nums, 0);

            Console.WriteLine(sum);
        }

        public static int RecursiveSum(int[] nums, int index)
        {
            if (index == nums.Length)
            {
                return 0;
            }

            return nums[index] + RecursiveSum(nums, index + 1);
        }
    }
}
