namespace Calculator
{
    public class Calc
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;

            var commaIndex = numbers.IndexOf(",");
            if (commaIndex > -1)
                return int.Parse(numbers.Substring(commaIndex + 1)) + int.Parse(numbers.Substring(0, commaIndex));
            
            //TODO: может Split? Но тогда лишний функционал появляется
            
            return int.Parse(numbers);
        }
    }
}