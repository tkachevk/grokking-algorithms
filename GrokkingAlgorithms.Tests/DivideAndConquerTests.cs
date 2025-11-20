using GrokkingAlgorithms.Algorithms;

public class DivideAndConquerTests
{
    [Theory]
    [InlineData(1680, 640, 80)]
    [InlineData(50, 25, 25)]
    [InlineData(1000001, 1000000, 1)]
    [InlineData(6, 3, 3)]
    [InlineData(2, 2, 2)]
    [InlineData(3, 6, 3)]
    [InlineData(-2, 2, 2)]
    [InlineData(-12, 18, 6)]
    [InlineData(18, -12, 6)]
    [InlineData(-4, -2, 2)]
    [InlineData(2, 0, 2)]
    [InlineData(0, 2, 2)]
    public void GCD_ValidCases(int a, int b, int expected)
    {
        // Act
        int result = DivideAndConquer.GCD(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}