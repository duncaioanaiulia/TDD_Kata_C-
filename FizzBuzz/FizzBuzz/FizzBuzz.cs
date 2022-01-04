using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        private const int _start = 1;
        private const int _end = 100;

        internal string GetText()
        {
            var stringBuilder = new StringBuilder();
            for (var i = _start; i <= _end; i++)
            {
                stringBuilder.Append(GetFizzBuzzList(i));
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

        public string GetFizzBuzzList(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if ((number % 3) == 0)
            {
                return "Fizz";
            }
            else if ((number % 5) == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}