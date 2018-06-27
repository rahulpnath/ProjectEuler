using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Lesson2_Fibonacci
    {
        public int Get()
        {
            return FibonacciLessThan(4000000)
                .Where(IsEven)
                .Sum();
        }

        private static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        private IEnumerable<int> FibonacciLessThan(int maxFib)
        {
            int n = 1;
            while (true)
            {
                var fib = Fibonacci(n);
                if (fib < maxFib)
                    yield return fib;
                else
                    yield break;
            }
        }

        public int Fibonacci(int n)
        {
            // memoize
            if (n == 0)
                return 1;

            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
