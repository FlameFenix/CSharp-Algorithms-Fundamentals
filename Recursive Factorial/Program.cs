using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        static long Factorial(long n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
