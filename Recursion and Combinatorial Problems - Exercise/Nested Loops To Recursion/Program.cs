using System;

namespace Nested_Loops_To_Recursion
{
    class Program
    {
        static int[] nums;
        static int[] combination;

        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            nums = new int[k];
            combination = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            NestedToRecursion(nums, 0);
        }

        private static void NestedToRecursion(int[] nums, int index)
        {
            if (index >= nums.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                combination[index] = nums[i];
                NestedToRecursion(nums, index + 1);
            }
        }
    }
}
