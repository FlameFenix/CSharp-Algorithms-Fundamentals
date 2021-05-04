using System;
using System.Linq;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int target = int.Parse(Console.ReadLine());

            int startIdx = 0;
            int endIdx = nums.Length - 1;

            int result = BinarySearching(nums, startIdx, endIdx, target);

            Console.WriteLine(result);

        }

        private static int BinarySearching(int[] nums, int startIdx, int endIdx, int target)
        {
            while (startIdx <= endIdx)
            {
                int mid = (startIdx + endIdx) / 2;
                int currentElement = nums[mid];

                if (currentElement == target)
                {
                    return mid;
                }

                if (target > currentElement)
                {
                    startIdx = mid + 1;
                }
                else if (target < currentElement)
                {
                    endIdx = mid - 1;
                }
                else
                {
                    break;
                }
            }

            return -1;
        }
    }
}
