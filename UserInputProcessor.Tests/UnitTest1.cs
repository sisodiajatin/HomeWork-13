using Xunit;
using Moq;

public class ATests
{
    [Fact]
    public void f1_ShouldReturnValuePlus1()
    {
        
        int input = 4;

        
        int result = A.f1(input);

        
        Assert.Equal(5, result);
    }

    [Fact]
    public void f2_ShouldReturnValuePlus2()
    {
        
        int input = 3;

        
        int result = A.f2(input);

        
        Assert.Equal(5, result);
    }

    [Fact]
    public void f5_ShouldReturnCorrectDivision()
    {
        
        int numerator = 10;
        int denominator = 2;

        
        double result = A.f5(numerator, denominator);

        
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void f6_ShouldReturnValuePlus5_WhenNonNegative()
    {
        
        int input = 7;

        
        int result = A.f6(input);

        
        Assert.Equal(12, result);
    }

    [Fact]
    public void f6_ShouldThrowException_WhenNegative()
    {
        
        int input = -1;

        
        var exception = Assert.Throws<Exception>(() => A.f6(input));
        Assert.Equal("x can't be negative", exception.Message);
    }

    [Fact]
    public void f7_ShouldAppendMoreStuff()
    {
        
        string input = "test";

        
        string result = A.f7(input);

        
        Assert.Equal("test more stuff", result);
    }

    [Fact]
    public void g1_ShouldCallInjected_f8_AndReturnResult()
    {
        
        var mockIA = new Mock<IA>();
        mockIA.Setup(m => m.f8(2)).Returns(42);

        
        int result = B.g1(2, mockIA.Object);

        
        Assert.Equal(42, result);
    }
}
