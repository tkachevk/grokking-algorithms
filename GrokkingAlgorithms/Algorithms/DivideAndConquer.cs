namespace GrokkingAlgorithms.Algorithms;

public static class DivideAndConquer
{
    public static int GCD(int a, int b)
    {
        if (a == 0) return Math.Abs(b);
        if (b == 0) return Math.Abs(a);

        while (b != 0)
            (a, b) = (b, a % b);

        return Math.Abs(a);
    }
}