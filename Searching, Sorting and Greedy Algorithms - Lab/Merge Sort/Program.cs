using System;
using System.Linq;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(" ", arr));
        }

        static void Sort(int[] arr, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx)
            {
                return;
            }

            int middleIdx = (startIdx + endIdx) / 2;

            Sort(arr, startIdx, middleIdx);

            Sort(arr, middleIdx + 1, endIdx);

            Merge(arr, startIdx, middleIdx, endIdx);

        }

        static void Merge(int[] arr, int startIdx, int middleIdx, int endIdx)
        {
            if (middleIdx < 0 ||
                middleIdx >= arr.Length ||
                arr[middleIdx] <= arr[middleIdx + 1])
            {
                return;
            }

            int[] originalArray = new int[arr.Length];

            int leftIdx = startIdx;
            int rightIdx = middleIdx + 1;

            for (int i = startIdx; i <= endIdx; i++)
            {
                originalArray[i] = arr[i];
            }

            for (int i = startIdx; i <= endIdx; i++)
            {
                if (leftIdx > middleIdx)
                {
                    arr[i] = originalArray[rightIdx++];
                }
                else if (rightIdx > endIdx)
                {
                    arr[i] = originalArray[leftIdx++];
                }
                else if (originalArray[leftIdx] <= originalArray[rightIdx])
                {
                    arr[i] = originalArray[leftIdx++];
                }
                else
                {
                    arr[i] = originalArray[rightIdx++];
                }
            }
        }
    }
}
