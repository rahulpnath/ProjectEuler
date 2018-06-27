using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class Lesson3_LargestPrime
    {
        public long Get()
        {
            return GetDivisors(600851475143)
            .Select(a => new { a, div = GetDivisors(a) })
            .Where(a => !a.div.Any())
            .Max(a => a.a);
        }

        public IEnumerable<long> GetDivisors(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    yield return i;
        }
    }
}
