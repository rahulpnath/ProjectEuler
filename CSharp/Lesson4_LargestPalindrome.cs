using System;
using System.Linq;

namespace CSharp
{
    class Lesson4_LargestPalindrome
    {
        public void Get()
        {
            var threeDigitNumbers = Enumerable.Range(100, 900);

            threeDigitNumbers
                .SelectMany(a => threeDigitNumbers.Select(b => a * b))
                .Where(IsPalindrome)
               .Max();
        }

        private bool IsPalindrome(int arg)
        {
            return arg.ToString() == new string(arg.ToString().Reverse().ToArray());
        }
    }
}
