using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class FizzBuzzLibTests
    {
        [TestMethod]
        public void GetFizzBuzzLines()
        {
            //Arrange
            var request = new FizzBuzzLib.FizzBuzzRequest {StartCount = 1, EndCount = 10000000};
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Foo", 3));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Bar", 5));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Bazz", 7));
            request.ValueTextPairs.Add(new FizzBuzzLib.FizzBuzzValueTextPair("Banana", 11));

            //Act
            var result = FizzBuzzLib.FizzBuzz.GetFizzBuzzLines(request);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(10000000, result.Count);
        }
    }
}
