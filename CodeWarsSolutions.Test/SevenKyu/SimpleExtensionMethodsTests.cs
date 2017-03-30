using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

[TestFixture]
public class SimpleExtensionMethodsTests
{
    [Test]
    public void ExampleTests()
    {
        const string name = "Alex";
        Assert.AreEqual("Hello, Alex!", name.SayHello());
        Assert.AreEqual("Goodbye, Alex. See you again soon!", name.SayGoodbye());
    }
}