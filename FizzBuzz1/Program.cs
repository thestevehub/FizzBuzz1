using System;

namespace FizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new FizzBuzzLib.FizzBuzzRequest {StartCount = 1, EndCount = 100};
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Foo", 3));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Bar", 5));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Bazz", 7));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Banana", 11));

            foreach (var line in FizzBuzzLib.FizzBuzz.GetFizzBuzzLines(request))
            {
                Console.WriteLine(line);
            }
        }


    }

    

}



