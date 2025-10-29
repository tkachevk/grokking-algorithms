using GrokkingAlgorithms.Algorithms;

public class SelectionSortTests
{
    [Theory]
    [InlineData(new int[] { 15, 10, 11, 1, 8 }, new int[] { 1, 8, 10, 11, 15 })]
    [InlineData(new int[] { 9999, 111, 3, 5, -1 }, new int[] { -1, 3, 5, 111, 9999 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, -1 }, new int[] { -1, 1, 2, 3, 4 })]
    public void Sort_SortsArrayCorrectly(int[] list, int[] expectedList)
    {
        // Act
        SelectionSort.Sort(list);

        // Assert
        Assert.Equal(expectedList, list);
    }
}