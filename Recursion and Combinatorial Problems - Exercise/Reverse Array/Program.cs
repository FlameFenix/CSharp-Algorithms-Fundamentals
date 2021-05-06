using System;
using System.Linq;
using System.Text;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            Console.WriteLine(ReverseArray(arr, arr.Length - 1));
        }

        static string ReverseArray(string[] arr, int index)
        {
            StringBuilder sb = new StringBuilder();

            if(index < 0)
            {
                return sb.ToString();
            }

            sb.Append(arr[index]);

            return sb.ToString() + " " + ReverseArray(arr, index - 1);
        }
    }
}
