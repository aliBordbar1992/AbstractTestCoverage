using AbstractTestCoverage.Code;

namespace AbstractTestCoverage.Test;

public abstract class AddClassTest
{
    [Fact]
    public void Test_Add()
    {
        var c = new AddClass();

        int a = 1;
        int b = 2;

        var result = c.Add(a, b);
        Assert.Equal(3, result);
    }
}

public class ImpAddClassTest : AddClassTest
{
    
}