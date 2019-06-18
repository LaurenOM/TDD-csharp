using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTestsNamespace
{
    [TestFixture]
    public class FizzBuzzTestsClass
    {
        private readonly FizzBuzzClass _fizzBuzz;

        public FizzBuzzTestsClass()
        {
            _fizzBuzz = new FizzBuzzClass();
        }

        [Test]
        public void ReturnFizzBuzzGivenValue15()
        {
            var result = _fizzBuzz.Main(15);
            Assert.AreEqual(result, "FizzBuzz");
        }
        [Test]
        public void ReturnFizzGivenValue3()
        {
            var result = _fizzBuzz.Main(3);
            Assert.AreEqual(result, "Fizz");
        }

        [Test]
        public void ReturnBuzzGivenValue5()
        {
            var result = _fizzBuzz.Main(5);
            Assert.AreEqual(result, "Buzz");
        }

                [Test]
        public void Return8GivenValue8()
        {
            var result = _fizzBuzz.Main(8);
            Assert.AreEqual(result, "8");
        }
    }
}