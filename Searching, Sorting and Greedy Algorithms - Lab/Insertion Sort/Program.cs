using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            for (int i = 1; i < nums.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    int firstElement = nums[j - 1];
                    int secondElement = nums[j];

                    if(secondElement < firstElement)
                    {
                        Swap(nums, j - 1, j);
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void Swap(int[] nums, int first, int second)
        {
            int backup = nums[first];
            nums[first] = nums[second];
            nums[second] = backup;
        }
    }
}
