using System.Collections.Generic;

namespace FizzBuzzLib5
{
    public class FizzBuzzValueTextPair
    {
        public FizzBuzzValueTextPair(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set;}
        public int Value { get; set; }
    }

    public class FizzBuzzRequest
    {
        public FizzBuzzRequest()
        {
            ValueTextPairs = new List<FizzBuzzValueTextPair>();
            StartCount = 1;
            EndCount = 100;
        }

        public List<FizzBuzzValueTextPair> ValueTextPairs { get; set; }

        public int StartCount { get; set; }
        public int EndCount { get; set; }
    }

    public abstract class FizzBuzz
    {
        public static List<string> GetFizzBuzzLines()
        {
            var request = new FizzBuzzRequest {StartCount = 1, EndCount = 100};
            request.ValueTextPairs.Add(new FizzBuzzValueTextPair("Fizz", 3));
            request.ValueTextPairs.Add(new FizzBuzzValueTextPair("Buzz", 5));

            return GetFizzBuzzLines(request);
        }

        public static List<string> GetFizzBuzzLines(FizzBuzzRequest request)
        {
            var lines = new List<string>();

            for (var i = request.StartCount; i <= request.EndCount; i++)
            {
                var lineOut = string.Empty;

                foreach (var valuePair in request.ValueTextPairs)
                {
                    if (i % valuePair.Value == 0) lineOut += valuePair.Text;
                }
                
                if (lineOut.Length == 0) lineOut = i.ToString();

                lines.Add(lineOut);
            }

            return lines;
        }
    }
}
