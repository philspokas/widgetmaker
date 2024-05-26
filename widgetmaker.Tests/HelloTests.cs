namespace widgetmaker.Tests;

public class HelloTests
{
    [Fact]
    public void HelloWorld_isHello()
    {
        string expected = "Hello World";
        string actual = "Hello World";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void HelloWorld_isNotHello()
    {
        string expected = "Hello World";
        string actual = "Goodbye world";
        Assert.NotEqual(expected, actual);
    }

}