using Xunit;
public class Tests
{
    [Fact]
    public void Test_suma()
    {
        int a=2;
        int b=3;
        int resultado = a + b;
        Assert.Equal(5, resultado);
    }
}