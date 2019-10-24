using NUnit.Framework;

namespace Open_Lab_02._06
{
    public class Tests
    {

        private Calculator calculator;

        [OneTimeSetUp]
        public void Init() => calculator = new Calculator();

        [Test]
        public void DivisibleTest([Range(0, 499, 5)] int number) =>
            Assert.That(calculator.Divisible(number), Is.EqualTo(number % 100 == 0));

    }
}
