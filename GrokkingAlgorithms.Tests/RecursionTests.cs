using GrokkingAlgorithms.Algorithms;

public class RecursionTests
{
    [Theory]
    [InlineData(3, 6)]
    [InlineData(2, 2)]
    [InlineData(4, 24)]
    [InlineData(5, 120)]
    public void Factorial_GettingCorrectlyValues(int num, int factorialNum)
    {
        // Act
        int result = Recursion.Factorial(num);

        // Assert
        Assert.Equal(factorialNum, result);
    }
}