using System;

namespace Generating_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Generate(0, array);
        }

        static void Generate(int index, int[] array)
        {
            if(index == array.Length)
            {
                Console.WriteLine(string.Join("", array));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    array[index] = i;
                    Generate(index + 1, array);
                }
            }
        }
    }
}
