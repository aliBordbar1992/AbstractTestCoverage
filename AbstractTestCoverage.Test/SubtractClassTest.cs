using AbstractTestCoverage.Code;

namespace AbstractTestCoverage.Test;

public class SubtractClassTest
{
    [Fact]
    public void Test_Subtract()
    {
        var c = new SubtractClass();

        int a = 5;
        int b = 2;

        var result = c.Subrtract(a, b);
        Assert.Equal(3, result);
    }
}