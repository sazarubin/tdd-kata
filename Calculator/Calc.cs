using System;

namespace Calculator
{
    public class Calc
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;
            
            return Int32.Parse(numbers);
        }
    }
}