namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void Test2AndStringEmpty()
    {
        Assert.False(!true);
        Assert.Empty("");
    }
}