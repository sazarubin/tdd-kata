using System;
using System.Linq;

namespace Calculator
{
    public class Calc
    {
        public int Add(string numbers)
        {
            return numbers.Split(',', StringSplitOptions.RemoveEmptyEntries).Sum(int.Parse);
        }
    }
}