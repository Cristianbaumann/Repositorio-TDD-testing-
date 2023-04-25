using NUnit.Framework;
using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestRightDateFormat()
    {
        const string input= "28/09/1891";
        const string expected = "28-09-1891";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestWrongDateFormat()
    {
        const string input= "28/09/1891";
        const string expected = "28-09-1891";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestEmptyDate()
    {
        const string input= "";
        const string expected = "";

        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    
}