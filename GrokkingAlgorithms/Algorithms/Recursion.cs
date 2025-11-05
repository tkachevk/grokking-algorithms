namespace GrokkingAlgorithms.Algorithms;

public static class Recursion
{
    public static int Factorial(int num)
    {
        if (num <= 1) return 1;

        return num * Factorial(num - 1);
    }
}