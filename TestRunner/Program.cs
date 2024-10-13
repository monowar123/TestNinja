using System;
using System.Collections.Generic;
using System.Linq;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            var _math = new TestNinja.Fundamentals.Math();
            var oddNumbers = _math.GetOddNumbers(limit);

            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
