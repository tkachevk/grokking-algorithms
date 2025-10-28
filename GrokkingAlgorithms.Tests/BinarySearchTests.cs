using GrokkingAlgorithms.Algorithms;

public class BinarySearchTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 3, 2)]
    [InlineData(new int[] { 4, 8, 12, 18, 55, 66, 78, 100, 499, 999 }, 499, 8)]
    [InlineData(new int[] { -100, 8, 12, 18, 55, 66, 78, 100, 499, 999 }, -100, 0)]
    [InlineData(new int[] { -100, 8, 12, 18, 55, 66, 78, 100, 499, 999 }, 999, 9)]
    [InlineData(new int[] { -100, 8, 12, 18, 55 }, 1000, -1)]
    public void Search_FindsExistingElement(int[] list, int item, int expected)
    {
        // Act
        int index = BinarySearch.Search(list, item);

        // Assert
        Assert.Equal(expected, index);
    }
}