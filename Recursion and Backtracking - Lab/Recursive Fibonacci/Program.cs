using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFibonacci(n));
        }

        private static int RecursiveFibonacci(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
    }
}
