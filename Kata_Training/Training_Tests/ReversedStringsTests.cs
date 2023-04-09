using NUnit.Framework;
using Training_Tasks;

namespace Training_Tests;

[TestFixture]
public class ReversedStringsTests
{
    [Test]
    [TestCase("world", ExpectedResult = "dlrow")]
    [TestCase("word", ExpectedResult = "drow")]
    [TestCase("paint", ExpectedResult = "tniap")]
    [TestCase("case", ExpectedResult = "esac")]
    [TestCase("exit", ExpectedResult = "tixe")]
    [TestCase("", ExpectedResult = "")]
    public static string String_Reverse_Tests(string sourceString)
    {
        return ReversedStrings.Reverse(sourceString);
    }
}