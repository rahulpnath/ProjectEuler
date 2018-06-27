using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Lesson5_SmallestMultiple
    {
        public void Get()
        {
            var numbers = Enumerable.Range(2, 9).Select(a => (long)a);
            LCM(1, numbers);
        }

        public long LCM(long a, IEnumerable<long> list)
        {
            if (!list.Any())
                return a;

            if (list.Count() == 1)
                return LCM(a, list.First());
            else
                return LCM(a, LCM(list.First(), list.Skip(1)));
        }

        public long LCM(long a, long b)
        {
            var gcdList = GetDivisors(a).Intersect(GetDivisors(b));
            var gcd = gcdList.Any() ? gcdList.Max() : 1;
            return (a * b) / gcd;
        }
        public IEnumerable<long> GetDivisors(long n)
        {
            for (long i = 2; i <= n; i++)
                if (n % i == 0)
                    yield return i;
        }
    }
}
