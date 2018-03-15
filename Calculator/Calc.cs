using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class Calc
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var separator = new [] {',', '\n'};

            if (numbers.StartsWith("//"))
            {
                separator[0] = numbers[2];
                numbers = numbers.Substring(4);
            }

            return numbers.Split(separator).Sum(int.Parse);
        }
    }
}