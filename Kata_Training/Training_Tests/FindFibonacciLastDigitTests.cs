using NUnit.Framework;
using Training_Tasks;

namespace Training_Tests;

[TestFixture]
public class FindFibonacciLastDigitTests
{
    [Test]
    [TestCase(193150, ExpectedResult = 5)]
    [TestCase(300, ExpectedResult = 0)]
    [TestCase(20001, ExpectedResult = 6)]
    [TestCase(800, ExpectedResult = 5)]
    [TestCase(1001, ExpectedResult = 1)]
    [TestCase(100, ExpectedResult = 5)]
    [TestCase(260, ExpectedResult = 5)]
    [TestCase(1111, ExpectedResult = 9)]
    [TestCase(1234, ExpectedResult = 7)]
    [TestCase(99999, ExpectedResult = 6)]
    [TestCase(10, ExpectedResult = 5)]
    [TestCase(234, ExpectedResult = 2)]
    [TestCase(193241, ExpectedResult = 1)]
    [TestCase(79, ExpectedResult = 1)]
    [TestCase(270, ExpectedResult = 0)]
    public static int Get_Fibonacci_Last_Digit_Tests(int index)
    {
        return FibonacciLastDigit.GetLastDigit(index);
    }
}