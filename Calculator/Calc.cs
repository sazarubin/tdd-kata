using System.Linq;

namespace Calculator
{
    public class Calc
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            return numbers.Split(',', '\n').Sum(int.Parse);
        }
    }
}